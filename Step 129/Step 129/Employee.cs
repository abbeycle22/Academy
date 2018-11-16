using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_129
{
    public class Employee : Person, IQuittable
    {
        public int x;
        public int y;

        public Employee()
        {
        }
        public Employee(int id1, int id2)
        {
            x = id1;
            y = id2;
        }
        public void ShowXY()
        {
            Console.WriteLine("{0}{1}", x, y);
        }
        //public override bool Equals(object id)
        //{
        //    if ((Employee)id.x == this.x && (Employee)id.y == this.y)
        //        return true;
        //    else
        //        return false;
        //}
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public static bool operator ==(Employee id1, Employee id2)
        {
            return id1.Equals(id2);
        }
        public static bool operator !=(Employee id1, Employee id2)
        {
            return ! id1.Equals(id2);
        }        
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
