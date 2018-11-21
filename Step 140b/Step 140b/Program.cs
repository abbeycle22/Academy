using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_140b
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee{FirstName = "Joe", LastName = "Smith", EmpID = 1},
                new Employee{FirstName = "Abbey", LastName = "Cleman", EmpID =2},
                new Employee{FirstName = "Lane", LastName = "Vehrenkamp", EmpID = 3},
                new Employee{FirstName = "Tyler", LastName = "Vehrenkamp", EmpID = 4},
                new Employee{FirstName = "Rosemary", LastName = "Vehrenkamp", EmpID = 5},
                new Employee{FirstName = "Paul", LastName = "Vehrenkamp", EmpID = 6},
                new Employee{FirstName = "John", LastName = "Dietz", EmpID = 7},
                new Employee{FirstName = "Casi", LastName = "Johnson", EmpID = 8},
                new Employee{FirstName = "Kyle", LastName = "Vehrenkamp", EmpID = 9},
                new Employee{FirstName = "Joe", LastName = "Jones", EmpID = 10},
            };

            //foreach loop
            //foreach(Employee Jemployee in listEmployees)
            //{
            //    if(Jemployee.FirstName == "Joe")
            //    {
            //        Console.WriteLine("Name : " + Jemployee.FirstName + " " + Jemployee.LastName + " \t\tEmployee ID: " + Jemployee.EmpID);
            //    }
            //}


            //Lambda expression
            //foreach (Employee Jemployee in listEmployees.FindAll(e => (e.FirstName == "Joe")).ToList())
            //{
            //    Console.WriteLine("Name : " + Jemployee.FirstName + " " + Jemployee.LastName + " \t\tEmployee ID: " + Jemployee.EmpID);
            //}

            foreach (Employee Jemployee in listEmployees.FindAll(e => (e.EmpID >= 5)).ToList())
            {
                Console.WriteLine("Name : " + Jemployee.FirstName + " " + Jemployee.LastName + " \t\tEmployee ID: " + Jemployee.EmpID);
            }

            Console.ReadLine();
        }
    }
}
