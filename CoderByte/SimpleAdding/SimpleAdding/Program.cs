// Using the C# language, have the function SimpleAdding(num) add up all the numbers
// from 1 to num. For the test cases, the parameter num will be any number from 1 to 1000.

using System;

namespace SimpleAdding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SimpleAdding(12));
            Console.WriteLine(SimpleAdding(140));
            Console.ReadKey();
        }

        public static int SimpleAdding(int num)
        {
            if (num <= 1)
                return 1;
            return num + SimpleAdding(num - 1);
        }
    }
}
