using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_131
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            Employee<int> employee1 = new Employee<int>();
            //public List<Employee> Things 
            employee.Things = new List<string>() { "Jesse", "Bill", "Bob" };
            employee1.Things = new List<int>() {2, 3, 4 };

            foreach (string thing in employee.Things)
            {
                Console.WriteLine(thing);
            }
            foreach (int thing in employee1.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();

        }

       
    }

    internal class T
    {
    }
}
