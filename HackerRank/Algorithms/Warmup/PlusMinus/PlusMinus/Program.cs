// https://www.hackerrank.com/challenges/plus-minus

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { -4, 3, -9, 0, 4, 1 };
            Console.WriteLine(PlusMinus(numbers));
            Console.ReadKey();
        }

        static string PlusMinus(int[] numbers)
        {
            decimal positive = 0.0m;
            decimal negative = 0.0m;
            decimal zero = 0.0m;

            foreach (var number in numbers)
            {
                if (number > 0)
                    positive++;
                if (number < 0)
                    negative++;
                if (number == 0)
                    zero++;
            }

            decimal decPositive = positive / numbers.Length;
            decimal decNegative = negative / numbers.Length;
            decimal decZero = zero / numbers.Length;

            string result = decPositive.ToString("N6") + "\n" + decNegative.ToString("N6") + "\n" + decZero.ToString("N6");
            return result;
        }
    }
}
