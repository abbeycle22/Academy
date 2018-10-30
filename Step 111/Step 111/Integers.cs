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

        public int FirstNumber
        {
            set
            {
                _firstNumber = value;
            }
            get
            {
                return _firstNumber;
            }
        }

        public int SecondNumber
        {
            set
            {
                _secondNumber = value;
            }
            get
            {
                return _secondNumber;
            }
        }


        public int Multiply()
        {
            int Multiply = _firstNumber * _secondNumber;
            return Multiply;
        }

        //public int Add()
        //{
        //    _return firstNumber + _secondNumber;
        //}

        //public int Subtract()
        //{
        //    return _firstNumber - _secondNumber;
        //}
    }
}
