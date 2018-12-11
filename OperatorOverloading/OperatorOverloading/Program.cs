using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.
            
            //1.0 Create Employee class with three paramaters: First Name, Last Name and ID. DONE
            //1.1 Instantiate first employee object DONE
            Employee em1 = new Employee();
            //1.2 Have user enter all three parameters for first employee object. DONE
            Console.WriteLine("Enter {0}'s info:", em1);
            em1.MakeEmployee();
            //1.3 Instatiate the second employee object. DONE
            Employee em2 = new Employee();
            Console.ReadLine();
            Console.Clear();
            //1.4 Have user enter all three paramaters for secound employee object
            Console.WriteLine("Enter {0}'s info:", em2);
            em2.MakeEmployee();
            Console.ReadLine();
            Console.Clear();
            //1.5 compaire the two employees
            bool test = em1 == em2;
            Console.WriteLine("Does employee 1 have the same ID as employee 2? {0}",test); 
            Console.ReadLine();
        }
    }
}
