using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_120
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public void SayName()
        {

            string FullName = firstName + " " + lastName;
            //string Name = "Name: " + FullName;
            Console.WriteLine("Name: " + FullName);

            //foreach (string fname in firstName)
            //{
            //    Console.WriteLine("Name: " + fname + lastName);
            //}
        }
        
    }
}
