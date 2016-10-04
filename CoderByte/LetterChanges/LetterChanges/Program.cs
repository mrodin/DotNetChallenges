// Using the C# language, have the function LetterChanges(str) take the str parameter being
// passed and modify it using the following algorithm.Replace every letter in the string with
// the letter following it in the alphabet (ie.c becomes d, z becomes a). Then capitalize
// every vowel in this new string (a, e, i, o, u) and finally return this modified string. 

using System;
using System.Collections.Generic;
using System.Linq;

namespace LetterChanges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LetterChanges("hello*3"));
            Console.WriteLine(LetterChanges("fun times!"));
            Console.WriteLine(LetterChanges("Argument goes here"));
            Console.ReadKey();
        }

        public static string LetterChanges(string str)
        {
            string result = Shift(str);
            result = CapitalizeVowels(result);
            return result;
        }

        static string Shift(string str)
        {
            char[] buffer = str.ToLower().ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                if (char.IsLetter(letter))
                {
                    letter = (char)(letter + 1);
                    if (letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                    else if (letter < 'a')
                    {
                        letter = (char)(letter + 26);
                    }
                    buffer[i] = letter;
                }
            }
            return new string(buffer);
        }

        static string CapitalizeVowels(string str)
        {
            var lookup = new HashSet<Char>() { 'a', 'e', 'i', 'o', 'u' };
            return new string(str.Select(x => lookup.Contains(x) ? char.ToUpper(x) : x).ToArray());
        }
    }
}
