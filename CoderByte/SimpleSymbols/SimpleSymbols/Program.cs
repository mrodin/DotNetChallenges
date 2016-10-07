// Using the C# language, have the function SimpleSymbols(str) take the str parameter being passed
// and determine if it is an acceptable sequence by either returning the string true or false. The
// str parameter will be composed of + and = symbols with several letters between them
// (ie. ++d+===+c++==a) and for the string to be true each letter must be surrounded by a + symbol.
// So the string to the left would be false. The string will not be empty and will have at least
// one letter. 

using System;
using System.Linq;

namespace SimpleSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SimpleSymbols("+d+=3=+s+"));
            Console.WriteLine(SimpleSymbols("f++d+"));
            Console.ReadKey();
        }

        public static string SimpleSymbols(string str)
        {
            str = "=" + str + "=";

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    if (!str[i-1].ToString().Contains('+') || !str[i+1].ToString().Contains('+'))
                    {
                        return "false";
                    }
                }
            }
            return "true";
        }
    }
}
