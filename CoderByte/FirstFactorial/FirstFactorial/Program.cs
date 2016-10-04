using System;

namespace FirstFactorial
{
    class Program
    {
        public static int FirstFactorial(int num)
        {
            if (num <= 1)
                return 1;
            return num * FirstFactorial(num - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(FirstFactorial(8));
            Console.ReadKey();
        }
    }
}
