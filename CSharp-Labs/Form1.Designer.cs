namespace CSharp_Labs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 28);
            label1.Name = "label1";
            label1.Size = new Size(435, 120);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 7);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 1;
            label2.Text = "Задание 1. Методы";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(580, 46);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(580, 23);
            label3.Name = "label3";
            label3.Size = new Size(172, 15);
            label3.TabIndex = 3;
            label3.Text = "Введите вещественное число:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(535, 82);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(695, 44);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(129, 22);
            button1.TabIndex = 5;
            button1.Text = "Вывести результат";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Lab 1: Задание 1. Методы: 1", "Lab 1: Задание 1. Методы: 3", "Lab 1: Задание 1. Методы: 5", "Lab 1: Задание 1. Методы: 7", "Lab 1: Задание 1. Методы: 9", "Lab 1: Задание 2. Условия: 1", "Lab 1: Задание 2. Условия: 3", "Lab 1: Задание 2. Условия: 5", "Lab 1: Задание 2. Условия: 7", "Lab 1: Задание 2. Условия: 9", "Lab 1: Задание 3. Циклы: 1", "Lab 1: Задание 3. Циклы: 3", "Lab 1: Задание 3. Циклы: 5", "Lab 1: Задание 3. Циклы: 7", "Lab 1: Задание 3. Циклы: 9", "Lab 1: Задание 4. Массивы: 1", "Lab 1: Задание 4. Массивы: 3", "Lab 1: Задание 4. Массивы: 5", "Lab 1: Задание 4. Массивы: 7", "Lab 1: Задание 4. Массивы: 9" });
            comboBox1.Location = new Point(896, 44);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(262, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(896, 23);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 7;
            label5.Text = "Select a task";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 471);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Labs";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Button button1;
        private ComboBox comboBox1;
        private Label label5;

        private Label valueLabel1;
        private Label valueLabel2;
        private Label valueLabel3;

        private TextBox textBox2;
        private TextBox textBox3;

    }
}