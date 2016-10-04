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
