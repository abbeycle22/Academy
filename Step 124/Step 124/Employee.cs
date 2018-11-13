using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_124
{
    class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("Name: ");
            base.SayName();
        }
        
    }
}
