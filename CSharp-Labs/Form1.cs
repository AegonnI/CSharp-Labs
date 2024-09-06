namespace CSharp_Labs
{
    public partial class Form1 : Form
    {

        string task;
        string errorMessage = "Incorrect input, try again!";

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

            textBox2 = new TextBox();
            textBox3 = new TextBox();
            Init_textBox(textBox2, textBox1.Location.X, textBox1.Location.Y + 30);
            Init_textBox(textBox3, textBox1.Location.X, textBox2.Location.Y + 30);
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;

            valueLabel1 = new Label();
            valueLabel2 = new Label();
            valueLabel3 = new Label();
            Init_label(valueLabel1, textBox1.Location.X - 30, textBox1.Location.Y);
            Init_label(valueLabel2, textBox1.Location.X - 30, textBox2.Location.Y);
            Init_label(valueLabel3, textBox1.Location.X - 30, textBox3.Location.Y);

            label4.Location = new(663, 151);
        }

        private void Init_textBox(TextBox textBox, int x, int y)
        {
            textBox.Location = new Point(x, y);
            textBox.Name = "textBox";
            textBox.Size = new Size(125, 27);
            //textBox.TabIndex = 2;
            Controls.Add(textBox);
        }

        private void Init_label(Label label, int x, int y)
        {
            label.AutoSize = true;
            label.Location = new Point(x, y);
            label.Name = "label";
            label.Size = new Size(141, 20);
            //label2.TabIndex = 1;
            label.Text = "";
            Controls.Add(label);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (task)
            {
                case "Lab 1: ������� 1. ������: 1":
                    if (!LabMath.IsDoubleNumber(textBox1.Text))
                    {
                        label4.Text = errorMessage;
                    }
                    else
                    {
                        label4.Text = "Result " + LabMath.fraction(double.Parse(textBox1.Text));
                    }
                    break;

                case "Lab 1: ������� 1. ������: 3":
                    if (!LabMath.IsChatADigit(textBox1.Text))
                    {
                        label4.Text = errorMessage;
                    }
                    else
                    {
                        label4.Text = "Result " + LabMath.charToNum(char.Parse(textBox1.Text));
                    }
                    break;

                case "Lab 1: ������� 1. ������: 5":
                    if (!LabMath.IsIntNumber(textBox1.Text))
                    {
                        label4.Text = errorMessage;
                    }
                    else
                    {
                        label4.Text = "Result " + LabMath.is2Digits(int.Parse(textBox1.Text));
                    }
                    break;

                case "Lab 1: ������� 1. ������: 7":
                    if (!LabMath.IsIntNumber(textBox1.Text) || !LabMath.IsIntNumber(textBox2.Text) || !LabMath.IsIntNumber(textBox3.Text))
                    {
                        label4.Text = errorMessage;
                    }
                    else
                    {
                        label4.Text = "Result " + LabMath.isInRange(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
                    }
                    break;

                case "Lab 1: ������� 1. ������: 9":
                    if (!LabMath.IsIntNumber(textBox1.Text) || !LabMath.IsIntNumber(textBox2.Text) || !LabMath.IsIntNumber(textBox3.Text))
                    {
                        label4.Text = errorMessage;
                    }
                    else
                    {
                        label4.Text = "Result " + LabMath.isEqual(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
                    }
                    break;

                case "Lab 1: ������� 2. �������: 1":
                    if (!LabMath.IsIntNumber(textBox1.Text))
                    {
                        label4.Text = errorMessage;
                    }
                    else
                    {
                        label4.Text = "Result " + LabMath.abs(int.Parse(textBox1.Text));
                    }
                    break;

                case "Lab 1: ������� 2. �������: 3":
                    if (!LabMath.IsIntNumber(textBox1.Text))
                    {
                        label4.Text = errorMessage;
                    }
                    else
                    {
                        label4.Text = "Result " + LabMath.is35(int.Parse(textBox1.Text));
                    }
                    break;

                case "Lab 1: ������� 2. �������: 5":
                    if (!LabMath.IsIntNumber(textBox1.Text) || !LabMath.IsIntNumber(textBox2.Text) || !LabMath.IsIntNumber(textBox3.Text))
                    {
                        label4.Text = errorMessage;
                    }
                    else
                    {
                        label4.Text = "Result " + LabMath.max3(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
                    }
                    break;

                case "Lab 1: ������� 2. �������: 7":
                    if (!LabMath.IsIntNumber(textBox1.Text) || !LabMath.IsIntNumber(textBox2.Text))
                    {
                        label4.Text = errorMessage;
                    }
                    else
                    {
                        label4.Text = "���������: �" + LabMath.sum2(int.Parse(textBox1.Text), int.Parse(textBox2.Text)) + "�";
                    }
                    break;

                case "Lab 1: ������� 2. �������: 9":
                    if (!LabMath.IsIntNumber(textBox1.Text))
                    {
                        label4.Text = errorMessage;
                    }
                    else
                    {
                        label4.Text = "���������: �" + LabMath.day(int.Parse(textBox1.Text)) + "�";
                    }
                    break;

                case "Lab 1: ������� 3. �����: 1":
                    if (!LabMath.IsPosetiveOfZeroInt(textBox1.Text))
                    {
                        label4.Text = errorMessage;
                    }
                    else
                    {
                        label4.Text = "���������: �" + LabMath.listNums(int.Parse(textBox1.Text)) + "�";
                    }
                    break;

                case "Lab 1: ������� 3. �����: 3":
                    if (!LabMath.IsPosetiveOfZeroInt(textBox1.Text))
                    {
                        label4.Text = errorMessage;
                    }
                    else
                    {
                        label4.Text = "���������: �" + LabMath.chet(int.Parse(textBox1.Text)) + "�";
                    }
                    break;

                case "Lab 1: ������� 3. �����: 5":
                    if (!LabMath.IsLongNumber(textBox1.Text))
                    {
                        label4.Text = errorMessage;
                    }
                    else
                    {
                        label4.Text = "���������: �" + LabMath.numLen(long.Parse(textBox1.Text)) + "�";
                    }
                    break;

                case "Lab 1: ������� 3. �����: 7":
                    if (!LabMath.IsPosetiveOfZeroInt(textBox1.Text))
                    {
                        label4.Text = errorMessage;
                    }
                    else
                    {
                        label4.Text = LabMath.square(int.Parse(textBox1.Text));
                    }
                    break;

                case "Lab 1: ������� 3. �����: 9":
                    if (!LabMath.IsPosetiveOfZeroInt(textBox1.Text))
                    {
                        label4.Text = errorMessage;
                    }
                    else
                    {
                        label4.Text = LabMath.rightTriangle(int.Parse(textBox1.Text));
                    }
                    break;

                case "Lab 1: ������� 4. �������: 1":
                    if (!LabMath.IsIntArray(textBox1.Text.Split(' ')) || !LabMath.IsIntNumber(textBox2.Text))
                    {
                        label4.Text = errorMessage;
                    }
                    else
                    {
                        label4.Text = "���������: �" + LabMath.findFirst(LabMath.StringToIntArr(textBox1.Text.Split(' ')), int.Parse(textBox2.Text)).ToString() + "�";
                    }
                    break;

                default:
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            task = comboBox1.Text;
            label4.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            switch (task)
            {
                case "Lab 1: ������� 1. ������: 1":
                    label2.Text = "������� 1. ������";
                    label1.Text = "������� �����.\r\n���� ��������� ������: public double fraction (double x);\r\n���������� ����������� ����� ����� �������, ����� �� ��������� ������\r\n������� ����� ����� �. ���������: ������������ ����� ����� ����\r\n������������� � ������ ����� ������������ ������� �����.\r\n������:\r\nx=5,25\r\n���������: 0,25\r\n";
                    label3.Text = "������� ������������ �����:";
                    ChangeVisible(true, false, false);
                    ChangeValueText("x = ");
                    break;

                case "Lab 1: ������� 1. ������: 3":
                    label2.Text = "������� 1. ������";
                    label1.Text = "����� � �����.\r\n���� ��������� ������: public int charToNum (char x);\r\n����� ��������� ������ �, ������� ������������ ����� ���� �� �0 1 2 3 4 5 6 7\r\n8 9�. ���������� ����������� ����� ����� �������, ����� �� ��������������\r\n������ � ��������������� �����. ���������: ��� ������� �0� � ��� ����� 48.\r\n������:\r\nx=�3�\r\n���������: 3\r\n";
                    label3.Text = "������� ���� ����� �� \"0 1 2 3 4 5 6 7 8 9\":";
                    ChangeVisible(true, false, false);
                    ChangeValueText("x = ");
                    break;

                case "Lab 1: ������� 1. ������: 5":
                    label2.Text = "������� 1. ������";
                    label1.Text = "����������.\r\n���� ��������� ������: public bool is2Digits (int x);\r\n���������� ����������� ����� ����� �������, ����� �� �������� ����� x �\r\n��������� true, ���� ��� ����������.\r\n������ 1:\r\nx=32\r\n���������: true\r\n������ 2:\r\nx=516\r\n���������: false\r\n";
                    label3.Text = "������� �����";
                    ChangeVisible(true, false, false);
                    ChangeValueText("x = ");
                    break;

                case "Lab 1: ������� 1. ������: 7":
                    label2.Text = "������� 1. ������";
                    label1.Text = "��������.\r\n���� ��������� ������: public bool isInRange (int a, int b, int num);\r\n����� ��������� ����� � ������ ������� (a � b) ���������� ���������\r\n���������. ���������� ����������� ����� ����� �������, ����� �� ���������\r\ntrue, ���� num ������ � ��������� �������� (������� �������). ��������\r\n��������, ��� ��������� a � b ������� ���������� (������ ��� �� ��� ������, �\r\n��� ������)\r\n������ 1:\r\na=5 b=1 num=3\r\n���������: true\r\n������ 2:\r\na=2 b=15 num=33\r\n���������: false\r\n";
                    label3.Text = "������� �����";
                    ChangeVisible(true, true, true);
                    ChangeValueText("a = ", "b = ", "num = ");
                    valueLabel3.Location = new(textBox1.Location.X - 50, textBox3.Location.Y);
                    break;

                case "Lab 1: ������� 1. ������: 9":
                    label2.Text = "������� 1. ������";
                    label1.Text = "���������.\r\n���� ��������� ������: public bool isEqual(int a, int b, int c);\r\n���������� ����������� ����� ����� �������, ����� �� ��������� true, ����\r\n��� ��� ���������� ������� ����� �����\r\n������ 1:\r\na=3 b=3 �=3\r\n���������: true\r\n������ 2:\r\na=2 b=15 �=2\r\n���������: false";
                    label3.Text = "������� �����";
                    ChangeVisible(true, true, true);
                    ChangeValueText("a = ", "b = ", "c = ");
                    valueLabel3.Location = new(textBox1.Location.X - 30, textBox3.Location.Y);
                    break;

                case "Lab 1: ������� 2. �������: 1":
                    label2.Text = "������� 2. �������";
                    label1.Text = "������ �����.\r\n���� ��������� ������: public int abs (int x);\r\n���������� ����������� ����� ����� �������, ����� �� ��������� ������\r\n����� � (���� ��� ���� �������������, �� ����� � ��������, ���� �� ����\r\n������������� � �� ���������� ������� ��� ��� ����� �����).\r\n������ 1:\r\nx=5\r\n���������: 5\r\n������ 2:\r\nx=-3\r\n���������: 3";
                    label3.Text = "������� �����";
                    ChangeVisible(true, false, false);
                    ChangeValueText("x = ");
                    break;

                case "Lab 1: ������� 2. �������: 3":
                    label2.Text = "������� 2. �������";
                    label1.Text = "�������� ����.\r\n���� ��������� ������: public bool is35 (int x);\r\n���������� ����������� ����� ����� �������, ����� �� ��������� true, ����\r\n����� x ������� ������ �� 3 ��� 5. ��� ����, ���� ��� ������� � �� 3, � �� 5, ��\r\n������� ���� false. ���������: �������� % ��������� �������� ������� ��\r\n�������.\r\n������ 1:\r\nx=5\r\n���������: true\r\n������ 2:\r\nx=8\r\n���������: false\r\n������ 3:\r\nx=15\r\n���������: false";
                    label3.Text = "������� �����";
                    ChangeVisible(true, false, false);
                    ChangeValueText("x = ");
                    break;

                case "Lab 1: ������� 2. �������: 5":
                    label2.Text = "������� 2. �������";
                    label1.Text = "������� ��������.\r\n���� ��������� ������: public int max3 (int x, int y, int z);\r\n���������� ����������� ����� ����� �������, ����� �� ���������\r\n������������ �� ���� ���������� ������� �����. ���������: ���������\r\n������� �������� ����� ��� ���������� if � �� �������� ��������� if.\r\n������ 1:\r\nx=5 y=7 z=7\r\n���������: 7\r\n������ 2:\r\nx=8 y=-1 z=4\r\n���������: 8";
                    label3.Text = "������� �����";
                    ChangeVisible(true, true, true);
                    ChangeValueText("x = ", "y = ", "z = ");
                    valueLabel3.Location = new(textBox1.Location.X - 30, textBox3.Location.Y);
                    break;

                case "Lab 1: ������� 2. �������: 7":
                    label2.Text = "������� 2. �������";
                    label1.Text = "������� �����.\r\n���� ��������� ������: public int sum2 (int x, int y);\r\n���������� ����������� ����� ����� �������, ����� �� ��������� �����\r\n����� x � y. ������, ���� ����� �������� � �������� �� 10 �� 19, �� ���� �������\r\n����� 20.\r\n������ 1:\r\nx=5 y=7\r\n���������: 20\r\n������ 2:\r\nx=8 y=-1\r\n���������: 7";
                    label3.Text = "������� �����";
                    ChangeVisible(true, true, false);
                    ChangeValueText("x = ", "y = ");
                    break;

                case "Lab 1: ������� 2. �������: 9":
                    label2.Text = "������� 2. �������";
                    label1.Text = "���� ������.\r\n���� ��������� ������: public String day (int x);\r\n����� ��������� ����� x, ������������ ���� ������. ���������� �����������\r\n����� ����� �������, ����� �� ��������� ������, ������� ����� ����������\r\n������� ���� ������, ��� 1- ��� �����������, � 7 � �����������. ���� ����� ��\r\n�� 1 �� 7 �� ������� ����� ���� �� ���� ������. ������ if � ������ ������\r\n����������� switch.\r\n������:\r\nx=5\r\n���������: ���������";
                    label3.Text = "������� �����";
                    ChangeVisible(true, false, false);
                    ChangeValueText("x = ");
                    break;

                case "Lab 1: ������� 3. �����: 1":
                    label2.Text = "������� 3. �����";
                    label1.Text = "����� ������.\r\n���� ��������� ������: public String listNums (int x);\r\n���������� ����������� ����� ����� �������, ����� �� ��������� ������, �\r\n������� ����� �������� ��� ����� �� 0 �� x (������������).\r\n������:\r\nx=5\r\n���������: �0 1 2 3 4 5�";
                    label3.Text = "������� �����";
                    ChangeVisible(true, false, false);
                    ChangeValueText("x = ");
                    break;

                case "Lab 1: ������� 3. �����: 3":
                    label2.Text = "������� 3. �����";
                    label1.Text = "������ �����.\r\n���� ��������� ������: public String chet (int x);\r\n���������� ����������� ����� ����� �������, ����� �� ��������� ������, �\r\n������� ����� �������� ��� ������ ����� �� 0 �� x (������������). ��������\r\n��� ����������� �������� ����: ���������� if ������������ �� �������.\r\n������:\r\nx=9\r\n���������: �0 2 4 6 8�";
                    label3.Text = "������� �����";
                    ChangeVisible(true, false, false);
                    ChangeValueText("x = ");
                    break;

                case "Lab 1: ������� 3. �����: 5":
                    label2.Text = "������� 3. �����";
                    label1.Text = "����� �����.\r\n���� ��������� ������: public int numLen (long x);\r\n���������� ����������� ����� ����� �������, ����� �� ��������� ����������\r\n������ � ����� x.\r\n���������:\r\nInt �=123/10; // � ����� ����� �������� 12\r\n������:\r\nx=12567\r\n���������: 5";
                    label3.Text = "������� �����";
                    ChangeVisible(true, false, false);
                    ChangeValueText("x = ");
                    break;

                case "Lab 1: ������� 3. �����: 7":
                    label2.Text = "������� 3. �����";
                    label1.Text = "�������.\r\n���� ��������� ������: public void square (int x);\r\n���������� ����������� ����� ����� �������, ����� �� ������� �� �����\r\n������� �� �������� �*� �������� �, � �������� � �������� � ��� � � �������� �\r\n������.\r\n������ 1:\r\nx=2\r\n���������:\r\n**\r\n**\r\n������ 2:\r\nx=4\r\n���������:\r\n****\r\n****\r\n****\r\n****";
                    label3.Text = "������� �����";
                    ChangeVisible(true, false, false);
                    ChangeValueText("x = ");
                    break;

                case "Lab 1: ������� 3. �����: 9":
                    label2.Text = "������� 3. �����";
                    label1.Text = "������ �����������.\r\n���� ��������� ������: public void rightTriangle (int x);\r\n���������� ����������� ����� ����� �������, ����� �� ������� �� �����\r\n����������� �� �������� �*� � �������� � �������� � ������, � ����������\r\n�������� � ���� ��������� � ������� ������, ��� ���� ����������� ��������\r\n�� ������� ����. ���������: ����� ��������� �*� ������� ��������\r\n����������� ���������� ��������.\r\n������ 1:\r\nx=3\r\n���������:\r\n *\r\n **\r\n***\r\n������ 2:\r\nx=4\r\n���������:\r\n *\r\n **\r\n ***\r\n****";
                    label3.Text = "������� �����";
                    ChangeVisible(true, false, false);
                    ChangeValueText("x = ");
                    break;

                case "Lab 1: ������� 4. �������: 1":
                    label2.Text = "������� 3. �����";
                    label1.Text = "������ �����������.\r\n���� ��������� ������: public void rightTriangle (int x);\r\n���������� ����������� ����� ����� �������, ����� �� ������� �� �����\r\n����������� �� �������� �*� � �������� � �������� � ������, � ����������\r\n�������� � ���� ��������� � ������� ������, ��� ���� ����������� ��������\r\n�� ������� ����. ���������: ����� ��������� �*� ������� ��������\r\n����������� ���������� ��������.\r\n������ 1:\r\nx=3\r\n���������:\r\n *\r\n **\r\n***\r\n������ 2:\r\nx=4\r\n���������:\r\n *\r\n **\r\n ***\r\n****";
                    label3.Text = "������� ����� �������(����� ������) � �����";
                    ChangeVisible(true, true, false);
                    ChangeValueText("arr = ","x = ");
                    break;

                default:
                    break;
            }

            void ChangeVisible(bool v1, bool v2, bool v3)
            {
                textBox1.Visible = v1;
                textBox2.Visible = v2;
                textBox3.Visible = v3;
            }

            void ChangeValueText(string v1, string v2 = "", string v3 = "")
            {
                valueLabel1.Text = v1;
                valueLabel2.Text = v2;
                valueLabel3.Text = v3;
            }
        }
    }
}