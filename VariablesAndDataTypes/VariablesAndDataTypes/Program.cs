using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //console.writeline("what is your name?");
            //string yourname = console.readline();
            //console.writeline("your name is: " + yourname);
            //console.readline();

            Console.WriteLine("What is your favorite number?");
            string favoriteNumber = Console.ReadLine();
            int favNum = Convert.ToInt32(favoriteNumber);
            int total = favNum + 5;
            Console.WriteLine("Your favorite number is plus 5 is: " + total);
            Console.ReadLine();
        }
    }
}
