using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Labs
{
    public static class LabMath
    {
        // Lab1 Ex1
        public static bool IsDoubleNumber(string number)
        {
            return double.TryParse(number, out var result);
        }

        public static double fraction(double x)
        {
            return (double)((decimal)x - (decimal)Math.Floor(x));
        }

        // Lab1 Ex2

        public static bool IsChatADigit(string digit)
        {
            return char.TryParse(digit.ToString(), out var result);
        }

        public static int charToNum(char x)
        {
            return (int)x - 48;
        }
    }
}
