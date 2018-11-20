using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step134
{
    class Program
    {
        public enum DaysOfTheWeek
        {
            Monday = 1,
            Tuesday = 3,
            Wednesday = 5,
            Thursday = 7,
            Friday = 9,
            Saturday = 11,
            Sunday = 13
        }

        static void Main(string[] args)
        {
            Console.WriteLine("What day is it?");
            string userDay = Console.ReadLine();

            DaysOfTheWeek weekDay;
            try
            {
                string value = userDay;
                weekDay = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), value);
                Console.WriteLine(userDay + " is an actual day of the week.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
        }

       

        
        
    }
}
