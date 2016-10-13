// https://www.hackerrank.com/challenges/staircase

using System;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            Staircase(6);
            Console.ReadKey();
        }

        static void Staircase(int n)
        {
            int spaceCount = n;
            int hashCount = 0;

            for (int i = 0; i < n; i++)
            {
                spaceCount--;
                hashCount++;

                string spaces = new string(' ', spaceCount);
                string hashes = new string('#', hashCount);
                string line = spaces + hashes;
                Console.WriteLine(line);
            }
        }
    }
}
