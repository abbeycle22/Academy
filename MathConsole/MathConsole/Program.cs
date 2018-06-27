using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number.");
            int multiply = Convert.ToInt32(Console.ReadLine());
            int product = multiply * 50;
            Console.WriteLine("Your total is " + product);
            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter a number.");
            int num = Convert.ToInt32(Console.ReadLine());
            int add = num + 25;
            Console.WriteLine("Your total is " + add);
            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter a number.");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());
            decimal div = num1 / 12.5m;
            Console.WriteLine("Your total is " + div);
            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter a number.");
            int num2 = Convert.ToInt32(Console.ReadLine());
            bool greaterThan50 = true;
            if (num2 > 50)
            {
                greaterThan50 = true;
            }
            else
            {
                greaterThan50 = false;
            }
            if (greaterThan50)
            {
                Console.WriteLine(num2 + " is greater than 50.");
            }
            else
            {
                Console.WriteLine(num2 + " is not greater than 50.");
            }
            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter a number.");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int remainder = num3 % 7;
            Console.WriteLine("Your remainder is " + remainder);
            Console.ReadLine();
            
         }
    }
}
