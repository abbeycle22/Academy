using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            Decimal pkgWeight = Convert.ToDecimal(Console.ReadLine());
            if (pkgWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            Console.ReadLine();
            Console.WriteLine("Please enter the package width:");
            Decimal pkgWidth = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please enter the package height:");
            Decimal pkgHeight = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please enter the package length:");
            Decimal pkgLength = Convert.ToDecimal(Console.ReadLine());
            Decimal pkgDim = (pkgHeight + pkgLength + pkgWidth); 
            if (pkgDim > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            Decimal totalCost = ((pkgDim * pkgWeight)/100);
            Decimal Cost = Convert.ToDecimal(totalCost);
            Console.WriteLine("Your estimated total for shipping is: " +totalCost.ToString("C"));

            Console.ReadLine();

        }

        
    }
}
