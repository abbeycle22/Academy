using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insurance Approval Form");
            Console.WriteLine();
            Console.WriteLine("What is your age?");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI?");
            string drink = Convert.ToString(Console.ReadLine());
            Console.WriteLine("How many speeding tickets have you had?");
            int num2 = Convert.ToInt16(Console.ReadLine());
            int age = 15;
            string dui = "no";
            int ticket = 3;
            Console.WriteLine("Qualified?");
            bool Qualified = (num1 > 15 && drink == "no" && num2 < ticket);
            Console.WriteLine(Qualified);


            Console.ReadLine();
        }
    }
}
