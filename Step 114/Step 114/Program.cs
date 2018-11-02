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
            decimal numTwo = .5m;
            int numThree = doIt.numThree;

            doIt.Answer(numOne);
            doIt.Money(numTwo);
            doIt.Change(numThree);

            Console.ReadLine();
        }
    }
}
