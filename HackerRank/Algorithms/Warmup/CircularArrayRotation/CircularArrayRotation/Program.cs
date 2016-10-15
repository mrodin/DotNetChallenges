// https://www.hackerrank.com/challenges/circular-array-rotation

using System;
using System.Collections.Generic;

namespace CircularArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> queries = new List<int> { 0, 1, 2 };
            List<int> numbers = new List<int> { 1, 2, 3 };
            int rotationCount = 2;

            CircularArrayRotation(numbers, rotationCount, queries);
            Console.ReadKey();
        }

        static void CircularArrayRotation(List<int> numbers, int rotationCount, List<int> queries)
        {
            for (int i = 0; i < rotationCount; i++)
            {
                int lastElement = numbers[numbers.Count - 1];
                numbers.Insert(0, lastElement);
                numbers.RemoveAt(numbers.Count - 1);
            }

            foreach (var query in queries)
            {
                Console.WriteLine(numbers[query]);
            }
        }
    }
}
