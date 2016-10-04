// Using the C# language, have the function CheckNums(num1,num2) take both parameters being
// passed and return the string true if num2 is greater than num1, otherwise return the string
// false. If the parameter values are equal to each other then return the string -1. 

using System;

namespace CheckNums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckNums(3, 122));
            Console.WriteLine(CheckNums(67, 67));
            Console.ReadKey();
        }

        private static string CheckNums(int num1, int num2)
        {
            if (num2 > num1)
            {
                return "true";
            }
            else if (num1 > num2)
            {
                return "false";
            }
            else
            {
                return "-1";
            }
        }
    }
}
