using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TimeConversion("07:05:45PM"));
            Console.ReadKey();
        }

        static string TimeConversion(string time)
        {
            DateTime dt = DateTime.Parse(time);
            return dt.ToString("HH:mm:ss");
        }
    }
}
