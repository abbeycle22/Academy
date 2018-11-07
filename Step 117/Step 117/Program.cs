using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_117
{
    class Program
    {
        static void Main(string[] args)
        {
            Half number = new Half();

            Console.WriteLine("Please enter a number: ");
            int numOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(number.Change(numOne));
            Console.ReadLine();

            
            Half age = new Half();
            int ageNow;
            Console.WriteLine(age.NumFour(out ageNow));
            Console.ReadLine();

            Half name = new Half();
            string Name;

            Console.WriteLine(age.NumFour(out Name));
            Console.ReadLine();
        }
        
    }
}
