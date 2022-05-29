namespace FloydAlgoritm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SetButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SecondNodeCalculateComboBox = new System.Windows.Forms.ComboBox();
            this.FirstNodeCalculateComboBox = new System.Windows.Forms.ComboBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CountOfNodesMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddNodeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddValueMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SecondAddComboBox = new System.Windows.Forms.ComboBox();
            this.FirstAddComboBox = new System.Windows.Forms.ComboBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightCoral;
            this.splitContainer1.Panel1.Controls.Add(this.SetButton);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.ClearButton);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.CountOfNodesMaskedTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(962, 515);
            this.splitContainer1.SplitterDistance = 322;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 2;
            // 
            // SetButton
            // 
            this.SetButton.Location = new System.Drawing.Point(22, 34);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(276, 23);
            this.SetButton.TabIndex = 2;
            this.SetButton.Text = "Set";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButtonClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CalculateButton);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.SecondNodeCalculateComboBox);
            this.groupBox2.Controls.Add(this.FirstNodeCalculateComboBox);
            this.groupBox2.Location = new System.Drawing.Point(22, 271);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(276, 153);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculate";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(200, 30);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(2);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(68, 99);
            this.CalculateButton.TabIndex = 5;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(10, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Chose to what node";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(10, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Chose from what node";
            // 
            // SecondNodeCalculateComboBox
            // 
            this.SecondNodeCalculateComboBox.FormattingEnabled = true;
            this.SecondNodeCalculateComboBox.Location = new System.Drawing.Point(12, 108);
            this.SecondNodeCalculateComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.SecondNodeCalculateComboBox.Name = "SecondNodeCalculateComboBox";
            this.SecondNodeCalculateComboBox.Size = new System.Drawing.Size(166, 21);
            this.SecondNodeCalculateComboBox.TabIndex = 1;
            // 
            // FirstNodeCalculateComboBox
            // 
            this.FirstNodeCalculateComboBox.FormattingEnabled = true;
            this.FirstNodeCalculateComboBox.Location = new System.Drawing.Point(12, 55);
            this.FirstNodeCalculateComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.FirstNodeCalculateComboBox.Name = "FirstNodeCalculateComboBox";
            this.FirstNodeCalculateComboBox.Size = new System.Drawing.Size(166, 21);
            this.FirstNodeCalculateComboBox.TabIndex = 0;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(22, 452);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(282, 37);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear All";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "How many nodes do you need:";
            // 
            // CountOfNodesMaskedTextBox
            // 
            this.CountOfNodesMaskedTextBox.Location = new System.Drawing.Point(248, 9);
            this.CountOfNodesMaskedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CountOfNodesMaskedTextBox.Mask = "000";
            this.CountOfNodesMaskedTextBox.Name = "CountOfNodesMaskedTextBox";
            this.CountOfNodesMaskedTextBox.Size = new System.Drawing.Size(50, 20);
            this.CountOfNodesMaskedTextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddNodeButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AddValueMaskedTextBox);
            this.groupBox1.Controls.Add(this.SecondAddComboBox);
            this.groupBox1.Controls.Add(this.FirstAddComboBox);
            this.groupBox1.Location = new System.Drawing.Point(22, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(276, 197);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AddConection";
            // 
            // AddNodeButton
            // 
            this.AddNodeButton.Location = new System.Drawing.Point(200, 30);
            this.AddNodeButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddNodeButton.Name = "AddNodeButton";
            this.AddNodeButton.Size = new System.Drawing.Size(68, 151);
            this.AddNodeButton.TabIndex = 5;
            this.AddNodeButton.Text = "Add Node";
            this.AddNodeButton.UseVisualStyleBackColor = true;
            this.AddNodeButton.Click += new System.EventHandler(this.AddNodeButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type value between nodes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chose second node to conect";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chose first node to conect";
            // 
            // AddValueMaskedTextBox
            // 
            this.AddValueMaskedTextBox.Location = new System.Drawing.Point(12, 161);
            this.AddValueMaskedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.AddValueMaskedTextBox.Name = "AddValueMaskedTextBox";
            this.AddValueMaskedTextBox.Size = new System.Drawing.Size(166, 20);
            this.AddValueMaskedTextBox.TabIndex = 5;
            // 
            // SecondAddComboBox
            // 
            this.SecondAddComboBox.FormattingEnabled = true;
            this.SecondAddComboBox.Location = new System.Drawing.Point(12, 108);
            this.SecondAddComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.SecondAddComboBox.Name = "SecondAddComboBox";
            this.SecondAddComboBox.Size = new System.Drawing.Size(166, 21);
            this.SecondAddComboBox.TabIndex = 1;
            // 
            // FirstAddComboBox
            // 
            this.FirstAddComboBox.FormattingEnabled = true;
            this.FirstAddComboBox.Location = new System.Drawing.Point(12, 55);
            this.FirstAddComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.FirstAddComboBox.Name = "FirstAddComboBox";
            this.FirstAddComboBox.Size = new System.Drawing.Size(166, 21);
            this.FirstAddComboBox.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer2.Size = new System.Drawing.Size(638, 515);
            this.splitContainer2.SplitterDistance = 371;
            this.splitContainer2.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.RosyBrown;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(638, 371);
            this.treeView1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.SlateGray;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(638, 140);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 515);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Floyd";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MaskedTextBox CountOfNodesMaskedTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox SecondAddComboBox;
        private System.Windows.Forms.ComboBox FirstAddComboBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddNodeButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox AddValueMaskedTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox SecondNodeCalculateComboBox;
        private System.Windows.Forms.ComboBox FirstNodeCalculateComboBox;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button SetButton;
    }
}

