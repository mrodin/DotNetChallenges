// https://www.hackerrank.com/challenges/maximum-perimeter-triangle

using System;

namespace MaximumPerimeterTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 8;
            //int[] l = { 1, 3, 1, 2, 4, 7, 6, 7 };

            int n = 3;
            int[] l = { 1, 2, 3 };

            MaximumPerimeterTriangle(n, l);

            Console.WriteLine(MaximumPerimeterTriangle(n, l));
            Console.ReadKey();
        }

        static string MaximumPerimeterTriangle(int n, int[] l)
        {
            string result = "";
            Array.Sort(l);

            for (int i = n - 3; i >= 0; i--)
            {
                if (l[i] + l[i + 1] > l[i + 2])
                {
                    return result = l[i] + " " + l[i + 1] + " " + l[i + 2];
                }
            }

            return result = "-1";
        }
    }
}
