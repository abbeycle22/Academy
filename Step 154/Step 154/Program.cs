using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Step_154
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            string userNumber = Console.ReadLine() ;
            File.WriteAllText(@"C:\Users\abbey\Desktop\TECH ACADEMY\c#\step154.txt", userNumber);

            Console.WriteLine();

            StreamReader sr = new StreamReader(@"C:\Users\abbey\Desktop\TECH ACADEMY\c#\step154.txt");
            userNumber = sr.ReadLine();
            while (userNumber != null)
            {
                Console.WriteLine("The number you entered is: " + userNumber);
                userNumber = sr.ReadLine();
            }
            sr.Close();
            Console.ReadLine();
        }

    }
}
