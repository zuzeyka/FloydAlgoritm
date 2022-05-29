using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace FloydAlgoritm
{
    public partial class Form1 : Form
    {
        private int NodeCount = 0; // количество узлов
        private double[,] WaysValueTable; // массив со значениями длин между узлами
        private string[,] AllWays; // массив отображаемых путей, возникших во время действия алгоритма
        public Form1()
        {
            InitializeComponent();
        }
        private void SetButtonClick(object sender, EventArgs e)
        {
            if (NodeCount == Convert.ToInt32(CountOfNodesMaskedTextBox.Text)) // если кнопка нажата и значение не изменилось отменяем выполнение функции
                return;
            NodeCount = Convert.ToInt32(CountOfNodesMaskedTextBox.Text);
            if (NodeCount > 1)
            {
                WaysValueTable = new double[NodeCount, NodeCount];
                AllWays = new string[NodeCount, NodeCount];
                for (int i = 0; i < NodeCount; i++)
                {
                    // добваляем поочередно узлы для выборе в комбобоксах
                    FirstAddComboBox.Items.Add(i + 1);
                    SecondAddComboBox.Items.Add(i + 1);
                    FirstNodeCalculateComboBox.Items.Add(i + 1);
                    SecondNodeCalculateComboBox.Items.Add(i + 1);
                    // добавляем узлы в дерево для более наглядной демонстрации
                    treeView1.Nodes.Add(Convert.ToString(i + 1));
                }
                for (int i = 0; i < NodeCount; i++)
                {
                    for (int j = 0; j < NodeCount; j++)
                    {
                        if (i == j) // если конечная точка и есть сам узел
                        {
                            // добавляем значение 0 означающее что не нужно никуда двигаться
                            WaysValueTable[i, j] = 0;
                            // добавляем путь равный самому узлу
                            AllWays[i, j] = Convert.ToString(i + 1);
                        }
                        else
                        {
                            // добавляем значение бесконечности означающее что узлы не связанны напрямую
                            WaysValueTable[i, j] = double.PositiveInfinity;
                            // устанавливаем что пути по заданому направлению не существует
                            AllWays[i, j] = null;
                        }
                    }
                }
            }
        }

        private void AddNodeButton_Click(object sender, EventArgs e)
        {
            if (FirstAddComboBox.SelectedIndex != SecondAddComboBox.SelectedIndex)
            {
                // инициализируем массив значениями длин путей между задаными пользователем узлами в обе стороны
                WaysValueTable[FirstAddComboBox.SelectedIndex, SecondAddComboBox.SelectedIndex] = Convert.ToDouble(AddValueMaskedTextBox.Text);
                WaysValueTable[SecondAddComboBox.SelectedIndex, FirstAddComboBox.SelectedIndex] = Convert.ToDouble(AddValueMaskedTextBox.Text);
                // инициализируем массив отображаемых путей в обе стороны
                AllWays[FirstAddComboBox.SelectedIndex, SecondAddComboBox.SelectedIndex] = $"{FirstAddComboBox.SelectedIndex + 1} -> {SecondAddComboBox.SelectedIndex + 1}";
                AllWays[SecondAddComboBox.SelectedIndex, FirstAddComboBox.SelectedIndex] = $"{SecondAddComboBox.SelectedIndex + 1} -> {FirstAddComboBox.SelectedIndex + 1}";
                // добавляем в дерево ветки из соединений между узлами
                treeView1.Nodes[SecondAddComboBox.SelectedIndex].Nodes.Add($"Conected with node {FirstAddComboBox.SelectedIndex + 1} (value {Convert.ToDouble(AddValueMaskedTextBox.Text)})");
                treeView1.Nodes[FirstAddComboBox.SelectedIndex].Nodes.Add($"Conected with node {SecondAddComboBox.SelectedIndex + 1} (value {Convert.ToDouble(AddValueMaskedTextBox.Text)})");
            }
            else
                MessageBox.Show("Select not equal nodes", "Error"); // если после нажатия кнопки выбраны одинаковые узлы - выдает ошибку и функция завершает работу
        }

        private void ClearButton_Click(object sender, EventArgs e) // очистка всех полей и вывод соотвествующего сообщения
        {
            treeView1.Nodes.Clear();
            FirstAddComboBox.Items.Clear();
            SecondAddComboBox.Items.Clear();
            FirstNodeCalculateComboBox.Items.Clear();
            SecondNodeCalculateComboBox.Items.Clear();
            AddValueMaskedTextBox.Text = null;
            CountOfNodesMaskedTextBox.Text = null;
            WaysValueTable = null;
            AllWays = null;
            NodeCount = 0;
            MessageBox.Show("You have cleared all data");
        }

        private void CalculateButton_Click(object sender, EventArgs e) // реализация алгоритма Флоида после нажатия кнопки
        {
            for (var k = 0; k < NodeCount; k++)
            {
                for (var i = 0; i < NodeCount; i++)
                {
                    for (var j = 0; j < NodeCount; j++)
                    {
                        if (WaysValueTable[i, j] > WaysValueTable[i, k] + WaysValueTable[k, j]) // проверка является ли длина конечного расстояния старого пути больше чем нового найденого 
                        {
                            // в случае если новый найденый путь является короче чем предыдущий - элемент текущей итерации перезаписывается
                            WaysValueTable[i, j] = WaysValueTable[i, k] + WaysValueTable[k, j];
                            // если параметры в сумме дают значение большее общему количеству узлов то убавляем их сумму на 1
                            // чтобы не было значение большее чем конечный узел
                            if (j > NodeCount / 2 || k > NodeCount / 2) 
                                AllWays[i, j] = AllWays[i, k] + " -> " + Convert.ToString(k + j - 1);
                            else
                                AllWays[i, j] = AllWays[i, k] + " -> " + Convert.ToString(k + j);
                        }
                    }
                }
            }
            // показ найденого кратчайшего пути и всех массивов
            richTextBox1.Text = AllWays[FirstNodeCalculateComboBox.SelectedIndex, SecondNodeCalculateComboBox.SelectedIndex] + "\nFloyd Matrix:";
            Print(true);
            richTextBox1.Text += "\nAll suitable ways:";
            Print(false);
        }

        private void Print(bool arr) // вывод одного из массива в текст бокс в зависимости от параметра функции
        {
            richTextBox1.Text += "\n";
            for (var i = 0; i < NodeCount; i++)
            {
                for (var j = 0; j < NodeCount; j++)
                {
                    if (arr)
                        richTextBox1.Text += Convert.ToString(WaysValueTable[i, j]) + " ";
                    else
                        richTextBox1.Text += Convert.ToString(AllWays[i, j]) + " & ";
                }
                richTextBox1.Text += "\n";
            }
        }
    }
}
