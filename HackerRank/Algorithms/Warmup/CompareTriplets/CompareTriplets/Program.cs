// https://www.hackerrank.com/challenges/compare-the-triplets

using System;

namespace CompareTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_a0 = new string[] { "5", "6", "7" };
            string[] tokens_b0 = new string[] { "3", "6", "10" };

            Console.WriteLine(CompareTriplets(tokens_a0, tokens_b0));
            Console.ReadKey();
        }

        static string CompareTriplets(string[] tokens_a, string[] tokens_b)
        {
            int aScore = 0;
            int bScore = 0;

            for (int i = 0; i < tokens_a.Length; i++)
            {
                int a = Convert.ToInt32(tokens_a[i]);
                int b = Convert.ToInt32(tokens_b[i]);

                if (a > b)
                    aScore++;
                if (a < b)
                    bScore++;
            }

            string result = aScore.ToString() + " " + bScore.ToString();
            return result;
        }
    }
}
