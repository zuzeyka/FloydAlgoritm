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
        private string OldWays;
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Text = "LOG:";
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
                Print(true);
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
            richTextBox1.Tag = "\n";
            OldWays = "\n";
            for (var i = 0; i < NodeCount; i++)
            {
                richTextBox1.Tag += Convert.ToString(i + 1) + " ";
                OldWays += Convert.ToString(i + 1) + " ";
                for (var j = 0; j < NodeCount; j++)
                {
                    richTextBox1.Tag += Convert.ToString(WaysValueTable[i, j]) + " |" + Convert.ToString(j + 1) + "| ";
                    OldWays += AllWays[i, j] + " |" + Convert.ToString(j + 1) + "| ";
                }
                richTextBox1.Tag += "\n";
                OldWays += "\n";
            }
            for (var k = 0; k < NodeCount; k++) // k отвечает за текущий узел с которым мы пытаемся создать связь,
              //если же длина в сочетании с длиной другого комбинированого узла будет меньшей чем препыдущий минимальный путь - то мы назначаем найдейный путь и его длину как наименьший
            {
                for (var i = 0; i < NodeCount; i++)
                {
                    for (var j = 0; j < NodeCount; j++)
                    {
                        if (WaysValueTable[i, j] > WaysValueTable[i, k] + WaysValueTable[k, j]) // проверка является ли длина конечного расстояния старого пути больше чем нового найденого 
                        {
                            // в случае если новый найденый путь является короче чем предыдущий - элемент текущей итерации перезаписывается
                            WaysValueTable[i, j] = WaysValueTable[i, k] + WaysValueTable[k, j];
                            // конечный узел пути равен переменной j + 1 которая отвечает за первый выбраный узел в текущей итерации по координате х
                            // + 1 так индексация массива начинается с 0 а узлы начинаются с 1
                            AllWays[i, j] = AllWays[i, k] + " -> " + Convert.ToString(j + 1);
                        }
                    }
                }
            }
            // показ найденого кратчайшего пути и всех массивов
            richTextBox1.Text = AllWays[FirstNodeCalculateComboBox.SelectedIndex, SecondNodeCalculateComboBox.SelectedIndex] + " - best way for secected nodes\nFloyd Matrix with connection values for every node:";
            Print(true);
            richTextBox1.Text += "\nFirst variant of value for every node matrix:";
            richTextBox1.Text +=  OldWays;
            richTextBox1.Text += "\nAll suitable ways for every pair of nodes:";
            Print(false);
            richTextBox1.Text += "\nFirst variant of ways for every node matrix:";
            richTextBox1.Text += richTextBox1.Tag;
        }

        private void Print(bool arr) // вывод одного из массива в текст бокс в зависимости от параметра функции
        {
            richTextBox1.Text += "\n";
            for (var i = 0; i < NodeCount; i++)
            {
                for (var j = 0; j < NodeCount; j++)
                {
                    if (arr)
                        richTextBox1.Text += Convert.ToString(WaysValueTable[i, j]) + " |" + Convert.ToString(j + 1) + "| ";
                    else
                        richTextBox1.Text += AllWays[i, j] + " |" + Convert.ToString(j + 1) + "| ";
                }
                richTextBox1.Text += "\n";
            }
        }
    }
}
