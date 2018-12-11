using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        public void MakeEmployee()
        {
            Console.WriteLine("Enter First Name: ");
            FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            LastName = Console.ReadLine();
            Console.WriteLine("Enter ID Number: ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(FirstName + " " + LastName + ", " + Id);
        }

        public static bool operator== (Employee employee1, Employee employee2)
        {
            bool test = employee1.Id == employee2.Id;
            return test;
        }
        public static bool operator!= (Employee employee1, Employee employee2)
        {
            bool test = employee1.Id != employee2.Id;
            return test;
        }

    }
}
