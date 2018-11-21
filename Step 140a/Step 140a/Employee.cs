using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_140a
{
    class Employee
    {
        public static object employees { get; internal set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmpID { get; set; }

        public override string ToString()
        {
            return "Name: " + FirstName +" "+ LastName + " " + "Employee ID: " + EmpID;
        }

        internal void Add(Employee aemployee)
        {
            throw new NotImplementedException();
        }
    }
}
