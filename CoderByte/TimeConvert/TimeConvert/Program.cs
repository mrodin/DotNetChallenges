// Using the C# language, have the function TimeConvert(num) take the num parameter being passed
// and return the number of hours and minutes the parameter converts to (ie. if num = 63 then
// the output should be 1:3). Separate the number of hours and minutes with a colon.

using System;

namespace TimeConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TimeConvert(126));
            Console.WriteLine(TimeConvert(45));
            Console.ReadKey();
        }

        public static string TimeConvert(int num)
        {
            int hours = num / 60;
            int minutes = num % 60;

            return hours + ":" + minutes;
        }
    }
}
