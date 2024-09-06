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
                case "Lab 1: Задание 1. Методы: 1":
                    label4.Text = LabMath.ResultDraw(
                        () => !LabMath.IsDoubleNumber(textBox1.Text) || !LabMath.IsDecimalNumber(textBox1.Text),
                        () => LabMath.fraction(double.Parse(textBox1.Text)).ToString());
                    break;

                case "Lab 1: Задание 1. Методы: 3":
                    label4.Text = LabMath.ResultDraw(
                        () => !LabMath.IsCharADigit(textBox1.Text),
                        () => LabMath.charToNum(char.Parse(textBox1.Text)).ToString());
                    break;

                case "Lab 1: Задание 1. Методы: 5":
                    label4.Text = LabMath.ResultDraw(
                        () => !LabMath.IsIntNumber(textBox1.Text),
                        () => LabMath.is2Digits(int.Parse(textBox1.Text)).ToString());
                    break;

                case "Lab 1: Задание 1. Методы: 7":
                    label4.Text = LabMath.ResultDraw(
                        () => !LabMath.IsIntNumber(textBox1.Text) || !LabMath.IsIntNumber(textBox2.Text) || !LabMath.IsIntNumber(textBox3.Text),
                        () => LabMath.isInRange(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text)).ToString());
                    break;

                case "Lab 1: Задание 1. Методы: 9":
                    label4.Text = LabMath.ResultDraw(
                        () => !LabMath.IsIntNumber(textBox1.Text) || !LabMath.IsIntNumber(textBox2.Text) || !LabMath.IsIntNumber(textBox3.Text),
                        () => LabMath.isEqual(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text)).ToString());
                    break;

                case "Lab 1: Задание 2. Условия: 1":
                    label4.Text = LabMath.ResultDraw(
                        () => !LabMath.IsIntNumber(textBox1.Text),
                        () => LabMath.abs(int.Parse(textBox1.Text)).ToString());
                    break;

                case "Lab 1: Задание 2. Условия: 3":
                    label4.Text = LabMath.ResultDraw(
                        () => !LabMath.IsIntNumber(textBox1.Text),
                        () => LabMath.is35(int.Parse(textBox1.Text)).ToString());
                    break;

                case "Lab 1: Задание 2. Условия: 5":
                    label4.Text = LabMath.ResultDraw(
                        () => !LabMath.IsIntNumber(textBox1.Text) || !LabMath.IsIntNumber(textBox2.Text) || !LabMath.IsIntNumber(textBox3.Text),
                        () => LabMath.max3(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text)).ToString());
                    break;

                case "Lab 1: Задание 2. Условия: 7":
                    label4.Text = LabMath.ResultDraw(
                        () => !LabMath.IsIntNumber(textBox1.Text) || !LabMath.IsIntNumber(textBox2.Text),
                        () => LabMath.sum2(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString());
                    break;

                case "Lab 1: Задание 2. Условия: 9":
                    label4.Text = LabMath.ResultDraw(
                        () => !LabMath.IsIntNumber(textBox1.Text),
                        () => LabMath.day(int.Parse(textBox1.Text)).ToString());
                    break;

                case "Lab 1: Задание 3. Циклы: 1":
                    label4.Text = LabMath.ResultDraw(
                        () => !LabMath.IsPosetiveOfZeroInt(textBox1.Text),
                        () => LabMath.listNums(int.Parse(textBox1.Text)).ToString());
                    break;

                case "Lab 1: Задание 3. Циклы: 3":
                    label4.Text = LabMath.ResultDraw(
                        () => !LabMath.IsPosetiveOfZeroInt(textBox1.Text),
                        () => LabMath.chet(int.Parse(textBox1.Text)).ToString());
                    break;

                case "Lab 1: Задание 3. Циклы: 5":
                    label4.Text = LabMath.ResultDraw(
                        () => !LabMath.IsLongNumber(textBox1.Text),
                        () => LabMath.numLen(long.Parse(textBox1.Text)).ToString());
                    break;

                case "Lab 1: Задание 3. Циклы: 7":
                    label4.Text = LabMath.ResultDraw(
                        () => !LabMath.IsPosetiveOfZeroInt(textBox1.Text),
                        () => LabMath.square(int.Parse(textBox1.Text)).ToString());
                    break;

                case "Lab 1: Задание 3. Циклы: 9":
                    label4.Text = LabMath.ResultDraw(
                        () => !LabMath.IsPosetiveOfZeroInt(textBox1.Text),
                        () => LabMath.rightTriangle(int.Parse(textBox1.Text)).ToString());
                    break;

                case "Lab 1: Задание 4. Массивы: 1":
                    label4.Text = LabMath.ResultDraw(
                        () => !LabMath.IsIntArray(textBox1.Text.Split(' ')) || !LabMath.IsIntNumber(textBox2.Text),
                        () => LabMath.findFirst(LabMath.StringToIntArr(textBox1.Text.Split(' ')), int.Parse(textBox2.Text)).ToString());
                    break;

                case "Lab 1: Задание 4. Массивы: 3":
                    label4.Text = LabMath.ResultDraw(
                        () => !LabMath.IsIntArray(textBox1.Text.Split(' ')),
                        () => LabMath.maxAbs(LabMath.StringToIntArr(textBox1.Text.Split(' '))).ToString());
                    break;

                case "Lab 1: Задание 4. Массивы: 5":
                    label4.Text = LabMath.ResultDraw(
                        () => !LabMath.IndexNotOutside(textBox1.Text.Split(' '), textBox3.Text) || !LabMath.IsIntArray(textBox2.Text.Split(' ')),
                        () => LabMath.IntArrToText(LabMath.add(LabMath.StringToIntArr(textBox1.Text.Split(' ')), LabMath.StringToIntArr(textBox2.Text.Split(' ')), int.Parse(textBox3.Text))).ToString());
                    break;

                case "Lab 1: Задание 4. Массивы: 7":
                    label4.Text = LabMath.ResultDraw(
                        () => !LabMath.IsIntArray(textBox1.Text.Split(' ')),
                        () => LabMath.IntArrToText(LabMath.reverseBack(LabMath.StringToIntArr(textBox1.Text.Split(' ')))).ToString());
                    break;

                case "Lab 1: Задание 4. Массивы: 9":
                    label4.Text = LabMath.ResultDraw(
                        () => !LabMath.IsIntArray(textBox1.Text.Split(' ')) || !LabMath.IsIntNumber(textBox2.Text),
                        () => LabMath.IntArrToText(LabMath.findAll(LabMath.StringToIntArr(textBox1.Text.Split(' ')), int.Parse(textBox2.Text))).ToString());
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
                case "Lab 1: Задание 1. Методы: 1":
                    label2.Text = "Задание 1. Методы";
                    label1.Text = "Дробная часть.\r\nДана сигнатура метода: public double fraction (double x);\r\nНеобходимо реализовать метод таким образом, чтобы он возвращал только\r\nдробную часть числа х. Подсказка: вещественное число может быть\r\nпреобразовано к целому путем отбрасывания дробной части.\r\nПример:\r\nx=5,25\r\nрезультат: 0,25\r\n";
                    label3.Text = "Введите вещественное число:";
                    ChangeInputField("x = ");
                    break;

                case "Lab 1: Задание 1. Методы: 3":
                    label2.Text = "Задание 1. Методы";
                    label1.Text = "Букву в число.\r\nДана сигнатура метода: public int charToNum (char x);\r\nМетод принимает символ х, который представляет собой один из “0 1 2 3 4 5 6 7\r\n8 9”. Необходимо реализовать метод таким образом, чтобы он преобразовывал\r\nсимвол в соответствующее число. Подсказка: код символа ‘0’ — это число 48.\r\nПример:\r\nx=’3’\r\nрезультат: 3\r\n";
                    label3.Text = "Введите одно число из \"0 1 2 3 4 5 6 7 8 9\":";
                    ChangeInputField("x = ");
                    break;

                case "Lab 1: Задание 1. Методы: 5":
                    label2.Text = "Задание 1. Методы";
                    label1.Text = "Двузначное.\r\nДана сигнатура метода: public bool is2Digits (int x);\r\nНеобходимо реализовать метод таким образом, чтобы он принимал число x и\r\nвозвращал true, если оно двузначное.\r\nПример 1:\r\nx=32\r\nрезультат: true\r\nПример 2:\r\nx=516\r\nрезультат: false\r\n";
                    label3.Text = "Введите число";
                    ChangeInputField("x = ");
                    break;

                case "Lab 1: Задание 1. Методы: 7":
                    label2.Text = "Задание 1. Методы";
                    label1.Text = "Диапазон.\r\nДана сигнатура метода: public bool isInRange (int a, int b, int num);\r\nМетод принимает левую и правую границу (a и b) некоторого числового\r\nдиапазона. Необходимо реализовать метод таким образом, чтобы он возвращал\r\ntrue, если num входит в указанный диапазон (включая границы). Обратите\r\nвнимание, что отношение a и b заранее неизвестно (неясно кто из них больше, а\r\nкто меньше)\r\nПример 1:\r\na=5 b=1 num=3\r\nрезультат: true\r\nПример 2:\r\na=2 b=15 num=33\r\nрезультат: false\r\n";
                    label3.Text = "Введите числа";
                    ChangeInputField("a = ", "b = ", "num = ");
                    valueLabel3.Location = new(textBox1.Location.X - 50, textBox3.Location.Y);
                    break;

                case "Lab 1: Задание 1. Методы: 9":
                    label2.Text = "Задание 1. Методы";
                    label1.Text = "Равенство.\r\nДана сигнатура метода: public bool isEqual(int a, int b, int c);\r\nНеобходимо реализовать метод таким образом, чтобы он возвращал true, если\r\nвсе три полученных методом числа равны\r\nПример 1:\r\na=3 b=3 с=3\r\nрезультат: true\r\nПример 2:\r\na=2 b=15 с=2\r\nрезультат: false";
                    label3.Text = "Введите числа";
                    ChangeInputField("a = ", "b = ", "c = ");
                    valueLabel3.Location = new(textBox1.Location.X - 30, textBox3.Location.Y);
                    break;

                case "Lab 1: Задание 2. Условия: 1":
                    label2.Text = "Задание 2. Условия";
                    label1.Text = "Модуль числа.\r\nДана сигнатура метода: public int abs (int x);\r\nНеобходимо реализовать метод таким образом, чтобы он возвращал модуль\r\nчисла х (если оно было положительным, то таким и остается, если он было\r\nотрицательным – то необходимо вернуть его без знака минус).\r\nПример 1:\r\nx=5\r\nрезультат: 5\r\nПример 2:\r\nx=-3\r\nрезультат: 3";
                    label3.Text = "Введите число";
                    ChangeInputField("x = ");
                    break;

                case "Lab 1: Задание 2. Условия: 3":
                    label2.Text = "Задание 2. Условия";
                    label1.Text = "Тридцать пять.\r\nДана сигнатура метода: public bool is35 (int x);\r\nНеобходимо реализовать метод таким образом, чтобы он возвращал true, если\r\nчисло x делится нацело на 3 или 5. При этом, если оно делится и на 3, и на 5, то\r\nвернуть надо false. Подсказка: оператор % позволяет получить остаток от\r\nделения.\r\nПример 1:\r\nx=5\r\nрезультат: true\r\nПример 2:\r\nx=8\r\nрезультат: false\r\nПример 3:\r\nx=15\r\nрезультат: false";
                    label3.Text = "Введите число";
                    ChangeInputField("x = ");
                    break;

                case "Lab 1: Задание 2. Условия: 5":
                    label2.Text = "Задание 2. Условия";
                    label1.Text = "Тройной максимум.\r\nДана сигнатура метода: public int max3 (int x, int y, int z);\r\nНеобходимо реализовать метод таким образом, чтобы он возвращал\r\nмаксимальное из трех полученных методом чисел. Подсказка: идеальное\r\nрешение включает всего две инструкции if и не содержит вложенных if.\r\nПример 1:\r\nx=5 y=7 z=7\r\nрезультат: 7\r\nПример 2:\r\nx=8 y=-1 z=4\r\nрезультат: 8";
                    label3.Text = "Введите числа";
                    ChangeInputField("x = ", "y = ", "z = ");
                    valueLabel3.Location = new(textBox1.Location.X - 30, textBox3.Location.Y);
                    break;

                case "Lab 1: Задание 2. Условия: 7":
                    label2.Text = "Задание 2. Условия";
                    label1.Text = "Двойная сумма.\r\nДана сигнатура метода: public int sum2 (int x, int y);\r\nНеобходимо реализовать метод таким образом, чтобы он возвращал сумму\r\nчисел x и y. Однако, если сумма попадает в диапазон от 10 до 19, то надо вернуть\r\nчисло 20.\r\nПример 1:\r\nx=5 y=7\r\nрезультат: 20\r\nПример 2:\r\nx=8 y=-1\r\nрезультат: 7";
                    label3.Text = "Введите числа";
                    ChangeInputField("x = ", "y = ");
                    break;

                case "Lab 1: Задание 2. Условия: 9":
                    label2.Text = "Задание 2. Условия";
                    label1.Text = "День недели.\r\nДана сигнатура метода: public String day (int x);\r\nМетод принимает число x, обозначающее день недели. Необходимо реализовать\r\nметод таким образом, чтобы он возвращал строку, которая будет обозначать\r\nтекущий день недели, где 1- это понедельник, а 7 – воскресенье. Если число не\r\nот 1 до 7 то верните текст “это не день недели”. Вместо if в данной задаче\r\nиспользуйте switch.\r\nПример:\r\nx=5\r\nрезультат: “пятница”";
                    label3.Text = "Введите число";
                    ChangeInputField("x = ");
                    break;

                case "Lab 1: Задание 3. Циклы: 1":
                    label2.Text = "Задание 3. Циклы";
                    label1.Text = "Числа подряд.\r\nДана сигнатура метода: public String listNums (int x);\r\nНеобходимо реализовать метод таким образом, чтобы он возвращал строку, в\r\nкоторой будут записаны все числа от 0 до x (включительно).\r\nПример:\r\nx=5\r\nрезультат: “0 1 2 3 4 5”";
                    label3.Text = "Введите число";
                    ChangeInputField("x = ");
                    break;

                case "Lab 1: Задание 3. Циклы: 3":
                    label2.Text = "Задание 3. Циклы";
                    label1.Text = "Четные числа.\r\nДана сигнатура метода: public String chet (int x);\r\nНеобходимо реализовать метод таким образом, чтобы он возвращал строку, в\r\nкоторой будут записаны все четные числа от 0 до x (включительно). Подсказа\r\nдля обеспечения качества кода: инструкцию if использовать не следует.\r\nПример:\r\nx=9\r\nрезультат: “0 2 4 6 8”";
                    label3.Text = "Введите число";
                    ChangeInputField("x = ");
                    break;

                case "Lab 1: Задание 3. Циклы: 5":
                    label2.Text = "Задание 3. Циклы";
                    label1.Text = "Длина числа.\r\nДана сигнатура метода: public int numLen (long x);\r\nНеобходимо реализовать метод таким образом, чтобы он возвращал количество\r\nзнаков в числе x.\r\nПодсказка:\r\nInt у=123/10; // у будет иметь значение 12\r\nПример:\r\nx=12567\r\nрезультат: 5";
                    label3.Text = "Введите число";
                    ChangeInputField("x = ");
                    break;

                case "Lab 1: Задание 3. Циклы: 7":
                    label2.Text = "Задание 3. Циклы";
                    label1.Text = "Квадрат.\r\nДана сигнатура метода: public void square (int x);\r\nНеобходимо реализовать метод таким образом, чтобы он выводил на экран\r\nквадрат из символов ‘*’ размером х, у которого х символов в ряд и х символов в\r\nвысоту.\r\nПример 1:\r\nx=2\r\nрезультат:\r\n**\r\n**\r\nПример 2:\r\nx=4\r\nрезультат:\r\n****\r\n****\r\n****\r\n****";
                    label3.Text = "Введите число";
                    ChangeInputField("x = ");
                    break;

                case "Lab 1: Задание 3. Циклы: 9":
                    label2.Text = "Задание 3. Циклы";
                    label1.Text = "Правый треугольник.\r\nДана сигнатура метода: public void rightTriangle (int x);\r\nНеобходимо реализовать метод таким образом, чтобы он выводил на экран\r\nтреугольник из символов ‘*’ у которого х символов в высоту, а количество\r\nсимволов в ряду совпадает с номером строки, при этом треугольник выровнен\r\nпо правому краю. Подсказка: перед символами ‘*’ следует выводить\r\nнеобходимое количество пробелов.\r\nПример 1:\r\nx=3\r\nрезультат:\r\n *\r\n **\r\n***\r\nПример 2:\r\nx=4\r\nрезультат:\r\n *\r\n **\r\n ***\r\n****";
                    label3.Text = "Введите число";
                    ChangeInputField("x = ");
                    break;

                case "Lab 1: Задание 4. Массивы: 1":
                    label2.Text = "Задание 4. Массивы";
                    label1.Text = "Поиск первого значения.\r\nДана сигнатура метода: public int findFirst (int[] arr, int x);\r\nНеобходимо реализовать метод таким образом, чтобы он возвращал индекс\r\nпервого вхождения числа x в массив arr. Если число не входит в массив –\r\nвозвращается -1.\r\nПример:\r\narr=[1,2,3,4,2,2,5]\r\nx=2\r\nрезультат: 1";
                    label3.Text = "Введите числа массива(через пробел) и число";
                    ChangeInputField("arr = ","x = ");
                    break;

                case "Lab 1: Задание 4. Массивы: 3":
                    label2.Text = "Задание 4. Массивы";
                    label1.Text = "Поиск максимального.\r\nДана сигнатура метода: public int maxAbs (int[] arr);\r\nНеобходимо реализовать метод таким образом, чтобы он возвращал\r\nнаибольшее по модулю (то есть без учета знака) значение массива arr.\r\nПример:\r\narr=[1,-2,-7,4,2,2,5]\r\nрезультат: -7";
                    label3.Text = "Введите числа массива(через пробел)";
                    ChangeInputField("arr = ");
                    break;

                case "Lab 1: Задание 4. Массивы: 5":
                    label2.Text = "Задание 4. Массивы";
                    label1.Text = "Добавление массива в массив.\r\nДана сигнатура метода: public int[] add (int[] arr, int[] ins, int pos);\r\nНеобходимо реализовать метод таким образом, чтобы он возвращал новый\r\nмассив, который будет содержать все элементы массива arr, однако в позицию\r\npos будут вставлены значения массива ins.\r\nПример:\r\narr=[1,2,3,4,5]\r\nins=[7,8,9]\r\npos=3\r\nрезультат: [1,2,3,7,8,9,4,5]";
                    label3.Text = "Введите числа массивов(через пробел) и число";
                    ChangeInputField("arr = ", "ins = ", "pos = ");
                    break;

                case "Lab 1: Задание 4. Массивы: 7":
                    label2.Text = "Задание 4. Массивы";
                    label1.Text = "Возвратный реверс.\r\nДана сигнатура метода: public int[] reverseBack (int[] arr);\r\nНеобходимо реализовать метод таким образом, чтобы он возвращал новый\r\nмассив, в котором значения массива arr записаны задом наперед.\r\nПример:\r\narr=[1,2,3,4,5]\r\nрезультат: [5,4,3,2,1]\r\n";
                    label3.Text = "Введите числа массив(через пробел)";
                    ChangeInputField("arr = ");
                    break;

                case "Lab 1: Задание 4. Массивы: 9":
                    label2.Text = "Задание 4. Массивы";
                    label1.Text = "Все вхождения.\r\nДана сигнатура метода: public int[] findAll (int[] arr, int x);\r\nНеобходимо реализовать метод таким образом, чтобы он возвращал новый\r\nмассив, в котором записаны индексы всех вхождений числа x в массив arr.\r\nПример:\r\narr=[1,2,3,8,2,2,9]\r\nx=2\r\nрезультат: [1,4,5]";
                    label3.Text = "Введите числа массив(через пробел)";
                    ChangeInputField("arr = ", "x = ");
                    break;

                default:
                    break;
            }

            void ChangeInputField(string v1 = "", string v2 = "", string v3 = "")
            {
                valueLabel1.Text = v1;
                valueLabel2.Text = v2;
                valueLabel3.Text = v3;

                textBox1.Visible = v1 != "";
                textBox2.Visible = v2 != "";
                textBox3.Visible = v3 != "";

                if (v3 != "")
                {
                    label4.Location = new Point(textBox3.Location.X, textBox3.Location.Y + 30);
                }
                else if (v2 != "")
                {
                    label4.Location = new Point(textBox2.Location.X, textBox2.Location.Y + 30);
                }
                else if (v1 != "")
                {
                    label4.Location = new Point(textBox1.Location.X, textBox1.Location.Y + 30);
                }
            }
        }
    }
}