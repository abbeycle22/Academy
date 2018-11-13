using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step113
{
   
    public class Numbers
    {
        public int numOne;
        public int numTwo;

        public void Answer(int x , int y)
        {
            //Console.WriteLine("Plsease select a number: ");
            //int numOne = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please select another number: ");
            //int numTwo = Convert.ToInt32(Console.ReadLine());

            numOne = 3;
            numTwo = 5;

            Console.WriteLine("The first number you chose multiplied by 2 is : " + 2 * numOne);
            Console.WriteLine("The second number you chose is: " + numTwo);

        Console.ReadLine();
        }

    }

}
