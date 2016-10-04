using System;

namespace FirstReverse
{
    class Program
    {
        public static string FirstReverse(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(FirstReverse("coderbyte"));
            Console.ReadKey();
        }
    }
}
