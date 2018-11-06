using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_114
{
    class Program
    {
        static void Main()
        {
            Math doIt = new Math();
            int numOne = 12;
            Console.WriteLine(doIt.Change(numOne));

            Math Decimal = new Math();
            decimal numTwo = .5m;
            Console.WriteLine(Decimal.Change(numTwo));

            Math Total = new Math();
            Console.WriteLine(Total.Change("5"));

            Console.ReadLine();
        }
    }
}
