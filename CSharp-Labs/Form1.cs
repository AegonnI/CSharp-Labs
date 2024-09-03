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
                case "Lab 1: ������� 1. ������: 1":
                    if (!LabMath.IsDoubleNumber(textBox1.Text))
                    {
                        label4.Text = "Incorrect input, try again!";
                    }
                    else
                    {
                        label4.Text = "Result " + LabMath.fraction(double.Parse(textBox1.Text));
                    }
                    break;

                case "Lab 1: ������� 1. ������: 3":
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
                case "Lab 1: ������� 1. ������: 1":
                    label2.Text = "������� 1. ������";
                    label1.Text = "������� �����.\r\n���� ��������� ������: public double fraction (double x);\r\n���������� ����������� ����� ����� �������, ����� �� ��������� ������\r\n������� ����� ����� �. ���������: ������������ ����� ����� ����\r\n������������� � ������ ����� ������������ ������� �����.\r\n������:\r\nx=5,25\r\n���������: 0,25\r\n";
                    label3.Text = "������� ������������ �����:";
                    label4.Text = string.Empty;
                    textBox1.Text = string.Empty;
                    break;

                case "Lab 1: ������� 1. ������: 3":
                    label2.Text = "������� 1. ������";
                    label1.Text = "����� � �����.\r\n���� ��������� ������: public int charToNum (char x);\r\n����� ��������� ������ �, ������� ������������ ����� ���� �� �0 1 2 3 4 5 6 7\r\n8 9�. ���������� ����������� ����� ����� �������, ����� �� ��������������\r\n������ � ��������������� �����. ���������: ��� ������� �0� � ��� ����� 48.\r\n������:\r\nx=�3�\r\n���������: 3\r\n";
                    label3.Text = "������� ���� ����� �� \"0 1 2 3 4 5 6 7 8 9\":";
                    label4.Text = string.Empty;
                    textBox1.Text = string.Empty;
                    break;

                default:
                    break;
            }
        }
    }
}