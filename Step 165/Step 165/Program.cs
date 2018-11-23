using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Step_165
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime todaysDate = DateTime.Now.Date;
            int yy = todaysDate.Year;

            try
            {
                Console.WriteLine("How old are you?");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age >= 1)
                {
                    int yearBorn = yy - age;
                    Console.WriteLine(yearBorn);
                    Console.ReadLine();
                }
                else
                {
                    throw new ArgumentOutOfRangeException();                 
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter numbers for your age.");
                Console.ReadLine();
               
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Cannot enter 0 or a negative number. Please try again!");
                Console.ReadLine();
            }

        }
    }
}
