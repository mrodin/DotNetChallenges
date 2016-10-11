// https://www.hackerrank.com/challenges/a-very-big-sum

using System;

namespace VeryBigSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
            Console.WriteLine(VeryBigSum(numbers));
            Console.ReadKey();
        }

        static long VeryBigSum(int[] numbers)
        {
            long result = 0;

            foreach (var number in numbers)
                result += number;

            return result;
        }
    }
}
