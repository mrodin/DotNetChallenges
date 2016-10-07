// Using the C# language, have the function AlphabetSoup(str) take the str string parameter being passed
// and return the string with the letters in alphabetical order (ie. hello becomes ehllo). Assume numbers
// and punctuation symbols will not be included in the string.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetSoup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AlphabetSoup("coderbyte"));
            Console.WriteLine(AlphabetSoup("hooplah"));
            Console.ReadKey();
        }

        public static string AlphabetSoup(string str)
        {
            return string.Concat(str.OrderBy(c => c));
        }
    }
}
