namespace CSharp_Labs
{
    public partial class Form1 : Form
    {

        string task;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = string.Empty;
            label1.Text = string.Empty;
            label3.Text = string.Empty;
            label4.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (task)
            {
                case "Lab 1: Задание 1. Методы: 1":
                    if (!LabMath.IsDoubleNumber(textBox1.Text))
                    {
                        label4.Text = "Incorrect input, try again!";
                    }
                    else
                    {
                        label4.Text = "Result " + LabMath.fraction(double.Parse(textBox1.Text));
                    }
                    break;

                case "Lab 1: Задание 1. Методы: 3":
                    if (!LabMath.IsChatADigit(textBox1.Text))
                    {
                        label4.Text = "Incorrect input, try again!";
                    }
                    else
                    {
                        label4.Text = "Result " + LabMath.charToNum(char.Parse(textBox1.Text));
                    }
                    break;

                default:
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            task = comboBox1.Text;
            switch (task)
            {
                case "Lab 1: Задание 1. Методы: 1":
                    label2.Text = "Задание 1. Методы";
                    label1.Text = "Дробная часть.\r\nДана сигнатура метода: public double fraction (double x);\r\nНеобходимо реализовать метод таким образом, чтобы он возвращал только\r\nдробную часть числа х. Подсказка: вещественное число может быть\r\nпреобразовано к целому путем отбрасывания дробной части.\r\nПример:\r\nx=5,25\r\nрезультат: 0,25\r\n";
                    label3.Text = "Введите вещественное число:";
                    label4.Text = string.Empty;
                    textBox1.Text = string.Empty;
                    break;

                case "Lab 1: Задание 1. Методы: 3":
                    label2.Text = "Задание 1. Методы";
                    label1.Text = "Букву в число.\r\nДана сигнатура метода: public int charToNum (char x);\r\nМетод принимает символ х, который представляет собой один из “0 1 2 3 4 5 6 7\r\n8 9”. Необходимо реализовать метод таким образом, чтобы он преобразовывал\r\nсимвол в соответствующее число. Подсказка: код символа ‘0’ — это число 48.\r\nПример:\r\nx=’3’\r\nрезультат: 3\r\n";
                    label3.Text = "Введите одно число из \"0 1 2 3 4 5 6 7 8 9\":";
                    label4.Text = string.Empty;
                    textBox1.Text = string.Empty;
                    break;

                default:
                    break;
            }
        }
    }
}