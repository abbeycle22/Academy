using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step113
{
    class Program
    {
        //public static int numOne { get; private set; }
        //public static int numTwo { get; private set; }

        public static void Main(string[] args)
        {

            //Numbers newOne = new Numbers();
            //int numOne = newOne.numOne;
            //int numTwo = newOne.numTwo;

            //newOne.Answer(numOne , numTwo);

            Numbers newOne = new Numbers();
            int numOne = newOne.numOne;
            int numTwo = newOne.numTwo;

            newOne.Answer(numOne, numTwo);

        }

        
    }
}
