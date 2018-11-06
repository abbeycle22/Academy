using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_115
{
    class Program
    {
        private static readonly int opt;
        private static int valueOne;

        static void Main()
        {
            More math = new More();

            int? v = null;


            Console.WriteLine("Please enter a number: ");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number if you would like if not hit enter: ");
            string input = Console.ReadLine();
            int valueOne;


            if (Int32.TryParse(input, out valueOne))
            {
                Console.WriteLine(math.Change(value, valueOne));
            }
            else
            {
                valueOne = v ?? 0;
                Console.WriteLine(math.Change(value, valueOne));
            }

            Console.ReadLine();
        }
    }
}
