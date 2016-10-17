// https://www.hackerrank.com/challenges/kangaroo

using System;

namespace Kangaroo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kangaroo(0, 3, 4, 2));
            Console.WriteLine(Kangaroo(0, 2, 5, 3));
            Console.ReadKey();
        }

        static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            int dx = x1 - x2;
            int dv = v2 - v1;

            if (dv == 0)
            {
                return "NO";
            }
            else if ((dx % dv == 0) && (dx / dv > 0))
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }
    }
}
