using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_111
{
    public class Integers
    {

        public int _firstNumber;
        public int _secondNumber;

        //public Integers()
        //{
        //}

        //public Integers (int _firstNumber, int _secondNumber)
        //{
        //    _firstNumber = firstNumber;
        //    _secondNumber = secondNumber;

        //}

        public int Multiply(int x , int y)
        {
            int Multiply = x * y;
            return Multiply;
        }

        public int Add(int x , int y)
        {
            int Add = x + y;
            return Add;
        }

        public int Subtract(int x, int y)
        {
            int Subtract = x - y;
            return Subtract;
        }
    }
}
