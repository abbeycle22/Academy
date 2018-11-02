using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_114
{
    public class Math
    {
        internal int numThree;

        public void Answer(int numOne)
        {

            Console.WriteLine("The answer to the problem is: " + (3 + numOne));

        }

        public void Money(decimal numTwo)
        {
            Console.WriteLine("The answer to the problem is: " + (3 * numTwo));
            

        }

        public void Change(int x)
        {
            Console.WriteLine("Choose a number: ");
            int numThree = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The answer this time is: " + (45 * numThree));

        }
    }
}
