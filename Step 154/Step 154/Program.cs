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
            File.WriteAllText(@"C:\Users\abbey\OneDrive\Documents\GitHub\Academy\Step 154", userNumber);
            Console.ReadLine();


        }
    }
}
