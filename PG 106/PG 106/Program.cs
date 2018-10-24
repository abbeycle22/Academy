using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG_106
{
    class Program
    {
        static void Main(string[] args)
        {

            //Number 1

            List<int> numbers = new List<int>() { 3, 5, 6, 8, 9, 15, 25 };
            //numbers.ForEach(Console.WriteLine);

            try
            { 
            Console.WriteLine("Pick a number.");
            int chosenNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            foreach (int n in numbers)
            {
                int answer = n / chosenNumber;
                Console.WriteLine(answer);
            }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException exy)
            {
                Console.WriteLine(exy.Message);
            }
            Console.WriteLine("I have emerged from the land of trying and catching!!! Yippee!!");
            Console.ReadLine();

        }
    }
}
