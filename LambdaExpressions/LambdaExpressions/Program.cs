using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main()
        {
            //1.In the Main() method, create a list of at least 10 employees. Each employee should have a first and last name, as well as an Id. At least two employees should have the first name "Joe".
            List<Employee> employees = new List<Employee>();
            Employee emp1 = new Employee(1, "Joe", "Smith");
            employees.Add(emp1);
            Employee emp2 = new Employee(2, "Jill", "Smithy");
            employees.Add(emp2);
            Employee emp3 = new Employee(3, "Joe", "Johnson");
            employees.Add(emp3);
            Employee emp4 = new Employee(4, "Ted", "Dougles");
            employees.Add(emp4);
            Employee emp5 = new Employee(5, "Robert", "Write");
            employees.Add(emp5);
            Employee emp6 = new Employee(6, "Jim", "White");
            employees.Add(emp6);
            Employee emp7 = new Employee(7, "Joe", "Black");
            employees.Add(emp7);
            Employee emp8 = new Employee(8, "Kerry", "Sutherland");
            employees.Add(emp8);
            Employee emp9 = new Employee(9, "Dan", "Silver");
            employees.Add(emp9);
            Employee emp10 = new Employee(10, "Alex", "Joy");
            employees.Add(emp10);
            Employee emp11 = new Employee(11, "Amy", "Smart");
            employees.Add(emp11);
            Employee emp12 = new Employee(12, "Zoe", "Tupper");
            employees.Add(emp12);
            //2.Using a foreach loop, create a new list of all employees with the first name "Joe".
            List<Employee> employees2 = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if(employee.FirstName == "Joe")
                {
                    employees2.Add(employee);
                }
            }
            foreach (Employee employee in employees2)
            {
                Console.WriteLine("First loop through");
                Console.WriteLine(employee.FirstName);
                Console.WriteLine("*******************************************");
            }
            //3.Do the same thing again, but this time with a lambda expression.
            List<Employee> employees3 = employees.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee employee in employees3)
            {
                Console.WriteLine("Secound loop through (with lambda expression)");
                Console.WriteLine(employee.FirstName);
                Console.WriteLine("*******************************************");
            }
            //4.Using a lambda expression, make a list of all employees with an Id number greater than 5.
            List<Employee> employeeIds = employees.Where(x => x.Id > 5).ToList();
            foreach (Employee employee in employeeIds)
            {
                Console.WriteLine("Employees with id # greater than 5");
                Console.WriteLine("{0} {1} ID#:{2}", employee.FirstName, employee.LastName, employee.Id);
                Console.WriteLine("*******************************************");
                
            }
            Console.ReadLine();
        }
    }
}
