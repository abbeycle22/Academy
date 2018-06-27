using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine();
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly rate?");
            int p1Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int p1Hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly rate?");
            int p2Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int p2Hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Annual Salary of Person 1");
            int p1Total = (p1Hour * p1Rate) * 52;
            Console.WriteLine(p1Total);
            Console.WriteLine("Annual Salary of Person 2");
            int p2Total = (p2Hour * p2Rate) * 52;
            Console.WriteLine(p2Total);
            Console.WriteLine("Does Person 1 make more than Person 2?");
            bool p1More = true;
            if (p1Total > p2Total) 
            {
                p1More = true;
            }
            else
            {
                p1More = false;
            }
            if (p1More)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False:");
            }
            Console.ReadLine();
            Console.WriteLine();


        }
    }
}
