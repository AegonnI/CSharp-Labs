using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Labs
{
    public static class LabMath
    {
        // Lab1 Ex1-1
        public static bool IsDoubleNumber(string number)
        {
            return double.TryParse(number, out var result);
        }

        public static double fraction(double x)
        {
            return (double)((decimal)x - (decimal)Math.Floor(x));
        }

        // Lab1 Ex1-3

        public static bool IsChatADigit(string digit)
        {
            return char.TryParse(digit.ToString(), out var result);
        }

        public static int charToNum(char x)
        {
            return (int)x - 48;
        }

        // Lab1 Ex1-5

        public static bool IsIntNumber(string number)
        {
            return int.TryParse(number, out var result) && !(number[0] == '0' && number.Length != 1);
        }

        public static bool is2Digits(int x)
        {
            return Math.Abs(x).ToString().Length == 2;
        }

        // Lab1 Ex1-7

        public static bool isInRange(int a, int b, int num)
        {
            return Math.Min(a, b) <= num && num <= Math.Max(a, b);
        }

        // Lab1 Ex1-9

        public static bool isEqual(int a, int b, int c)
        {
            return (a == b) && (b == c);
        }

        // Lab1 Ex2-1

        public static int abs(int x)
        {
            if (x >= 0)
            {
                return x;
            }
            return -1 * x;
        }

        // Lab1 Ex2-3

        public static bool is35(int x)
        {
            return (x % 5 == 0) != (x % 3 == 0);
        }

        // Lab1 Ex2-5

        public static int max3(int x, int y, int z)
        {
            return Math.Max(Math.Max(x, y), z);
        }

        // Lab1 Ex2-7

        public static int sum2(int x, int y)
        {
            if (10 <= x+y && x+y <= 19)
            {
                return 20;
            }
            return x+y;
        }

        // Lab1 Ex2-9

        public static String day(int x)
        {
            switch (x)
            {
                case 1:
                    return "понедельник";
                case 2:
                    return "вторник";
                case 3:
                    return "среда";
                case 4:
                    return "четверг";
                case 5:
                    return "пятница";
                case 6:
                    return "суббота";
                case 7:
                    return "воскресенье";
                default:
                    return "это не день недели";
            }
        }

        // Lab1 Ex3-1

        public static String listNums(int x)
        {
            string result = String.Empty;

            for (int i = 0; i <= x; i++)
            {
                result += i.ToString() + ' ';
            }

            return result.Substring(0, result.Length-1);
        }
    }
}
