// Using the C# language, have the function LetterCapitalize(str) take the str parameter being
// passed and capitalize the first letter of each word. Words will be separated by only one space.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterCapitalize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LetterCapitalize("hello world"));
            Console.WriteLine(LetterCapitalize("i ran there"));
            Console.ReadKey();
        }

        public static string LetterCapitalize(string str)
        {
            string[] words = str.Split();

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                words[i] = char.ToUpper(word[0]) + word.Substring(1);
            }

            return string.Join(" ", words);
        }
    }
}
