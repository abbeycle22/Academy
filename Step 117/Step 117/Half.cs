using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_117
{
    public class Half
    {
        public int Change(int numOne)
        {
            int x = numOne;
            x = numOne / 2;
            return x;
        }

        public int NumFour(out int ageNow)
        {
            ageNow = 36;
           
           
            return ageNow;
        }

        public string NumFour(out string myName)
        {
            myName = "Abbey";
            return myName;
        }
    }
}
