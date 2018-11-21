using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_140
{
    class Program
    {

        public class Employee    
        {
            //public Employee (string FirstName, string LastName, int EmpID)
            //{
            //    FirstName = firstName;
            //    LastName = lastName;
            //    EmpID = empID;
            //}
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int EmpID { get; set; }

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Smith", EmpID = 1 });
                employees.Add(new Employee() { FirstName = "Abbey", LastName = "Cleman", EmpID = 2 });
                employees.Add(new Employee() { FirstName = "Lorri", LastName = "Henry", EmpID = 3 });
                employees.Add(new Employee { FirstName = "Bryan", LastName = "Finlay", EmpID = 4 });
                employees.Add(new Employee { FirstName = "Tyler", LastName = "Vehrenkamp", EmpID = 5 });
                employees.Add(new Employee { FirstName = "Lane", LastName = "Vehrenkamp", EmpID = 6 });
                employees.Add(new Employee { FirstName = "Joe", LastName = "Jones", EmpID = 7 });
                employees.Add(new Employee { FirstName = "Lance", LastName = "Poole", EmpID = 8 });
                employees.Add(new Employee { FirstName = "Erin", LastName = "Deschermeier", EmpID = 9 });
                employees.Add(new Employee { FirstName = "Steven", LastName = "Deschermeier", EmpID = 10 });
                employees.Add(new Employee { FirstName = "John", LastName = "Dietz", EmpID = 11 });
        }
        static void Main(string[] args)
        {
                //List<Employee> employees = new List<Employee>();
                //employees.Add(new Employee() { FirstName = "Joe", LastName = "Smith", EmpID = 1 });
                //employees.Add(new Employee() { FirstName = "Abbey", LastName = "Cleman", EmpID = 2 });
                //employees.Add(new Employee() { FirstName = "Lorri", LastName = "Henry", EmpID = 3 });
                //employees.Add(new Employee { FirstName = "Bryan", LastName = "Finlay", EmpID = 4 });
                //employees.Add(new Employee { FirstName = "Tyler", LastName = "Vehrenkamp", EmpID = 5 });
                //employees.Add(new Employee { FirstName = "Lane", LastName = "Vehrenkamp", EmpID = 6 });
                //employees.Add(new Employee { FirstName = "Joe", LastName = "Jones", EmpID = 7 });
                //employees.Add(new Employee { FirstName = "Lance", LastName = "Poole", EmpID = 8 });
                //employees.Add(new Employee { FirstName = "Erin", LastName = "Deschermeier", EmpID = 9 });
                //employees.Add(new Employee { FirstName = "Steven", LastName = "Deschermeier", EmpID = 10 });
                //employees.Add(new Employee { FirstName = "John", LastName = "Dietz", EmpID = 11 });
            
        }
            //Console.WriteLine();
            //Console.ReadLine();

            //foreach (Employee employee in employees)
            //{
            //    if(FirstName == "Joe")
            //    {
            //        object NewList = null;
            //        NewList.Add(Employee.FirstName, Employee.LastName, Employee.EmpID);
            //    }

            //}

        }
    
    }
}
