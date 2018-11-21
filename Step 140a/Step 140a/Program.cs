using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_140a
{
    class Program
    {

        static void Main()
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee() { FirstName = "Joe", LastName = "Smith", EmpID = 1 });
            employees.Add(new Employee() { FirstName = "Abbey", LastName = "Cleman", EmpID = 2 });
            employees.Add(new Employee() { FirstName = "Lorri", LastName = "Henry", EmpID = 3 });
            employees.Add(new Employee() { FirstName = "Bryan", LastName = "Finlay", EmpID = 4 });
            employees.Add(new Employee() { FirstName = "Tyler", LastName = "Vehrenkamp", EmpID = 5 });
            employees.Add(new Employee() { FirstName = "Lane", LastName = "Vehrenkamp", EmpID = 6 });
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Jones", EmpID = 7 });
            employees.Add(new Employee() { FirstName = "Lance", LastName = "Poole", EmpID = 8 });
            employees.Add(new Employee() { FirstName = "Erin", LastName = "Deschermeier", EmpID = 9 });
            employees.Add(new Employee() { FirstName = "Steven", LastName = "Deschermeier", EmpID = 10 });
            employees.Add(new Employee() { FirstName = "John", LastName = "Dietz", EmpID = 11 });

            Console.WriteLine();
            foreach (Employee aemployee in employees)
            {
                string FirstName = null;
                if (FirstName == "Joe")
                {
                    //employees.Add(aemployee);
                    Console.WriteLine(employees);
                }
            }

           
            //Console.WriteLine(employee3);

            //Console.WriteLine(employees);
            Console.ReadLine();
        }
    }
}
