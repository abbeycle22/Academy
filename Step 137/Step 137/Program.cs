using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_137
{
    class Program
    {       
        struct Number
        {
            public decimal Amount;
        }
        static void Main(string[] args)
        {
            Number N;
            N.Amount = 2005m;
            Console.WriteLine("The amount is " + N.Amount);
            Console.ReadLine();

        }
    }
}
