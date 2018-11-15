using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_126
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: ");
            base.SayName();
        }

        public void Quit()
        {
            Console.WriteLine("To come later!");
        }

        //public void Quit(Person person)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
