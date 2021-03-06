﻿// Have the function LongestWord(sen) take the sen parameter being passed and return the largest
// word in the string. If there are two or more words that are the same length, return the first
// word from the string with that length. Ignore punctuation and assume sen will not be empty. 

using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace LongestWord
{
    class Program
    {
        public static string LongestWord(string sen)
        {
            var longestWord = Regex.Matches(sen, @"\b[\w]*\b")
                .Cast<Match>()
                .OrderByDescending(m => m.Length)
                .First()
                .ToString();

            return longestWord;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(LongestWord("fun&!! time dinosaur"));
            Console.ReadKey();
        }
    }
}
