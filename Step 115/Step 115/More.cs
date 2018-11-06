using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_115
{
    class More
    {
        public int Change(int value , int valueOne = 0)
        {
            //public Nullable<int> opt;
            //public int? valueOne = null; 

            int x = value;
            int y = valueOne;
            x = 23 + value + y;
            return x;
            
        }

      
    }  
}