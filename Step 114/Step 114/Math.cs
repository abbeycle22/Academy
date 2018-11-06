using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_114
{
    public class Math
    {

      

        public int Change(int numOne)
        {
            int x = numOne;
            x = 3 + numOne;
            return x; 

        }

        public decimal Change(decimal numTwo)
        {
            decimal x = numTwo;
            x = 3 * x;
            return x; 
      

        }

        public int Change(string numThree)
        {
           int x = Convert.ToInt32(numThree);
            x = x * 45;
            return x; 

        }
    }
}
