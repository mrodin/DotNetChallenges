// Have the function FirstFactorial(num) take the num parameter being passed and return the
// factorial of it(e.g. if num = 4, return (4 * 3 * 2 * 1)).

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
