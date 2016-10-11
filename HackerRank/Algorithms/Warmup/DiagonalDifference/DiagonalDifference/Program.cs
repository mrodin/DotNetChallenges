// https://www.hackerrank.com/challenges/diagonal-difference

using System;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[][] { new int[] { 11, 2, 4 }, new int[] { 4, 5, 6 }, new int[] { 10, 8, -12 } };

            Console.WriteLine(DiagonalDifference(matrix));
            Console.ReadKey();
        }

        static int DiagonalDifference(int[][] matrix)
        {
            int diagSum1 = 0;
            int diagSum2 = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                diagSum1 += matrix[i][i];
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                diagSum2 += matrix[i][(matrix.Length - 1) - i];
            }

            return Math.Abs(diagSum1 - diagSum2);
        }
    }
}