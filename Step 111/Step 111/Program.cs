﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_111
{
    class Program
    {
        static void Main(string[] args)
        {
            Integers myClass = new Integers();

            Console.WriteLine("Plsease type first number: ");
            int _firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please type second number: ");
            int _secondNumber = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine(myClass.Multiply());
            Console.WriteLine("The product of " + _firstNumber + " and " + _secondNumber + " is: " + myClass.Multiply());


            Console.ReadLine();
        }

        

    }
    
}
