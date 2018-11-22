using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Step_156
{
    class Program
    {
        static void Main(string[] args)
        {
            //public static DateTime Now { get; }
            Console.WriteLine(DateTime.Now);
            DateTime timeNow = DateTime.Now;
            Console.WriteLine();
            Console.WriteLine("Please enter a number.");
            int hours = Convert.ToInt32(Console.ReadLine());

            DateTime later = timeNow.AddHours(hours);
            Console.WriteLine(later);
            Console.ReadLine();
        }
    }
}
