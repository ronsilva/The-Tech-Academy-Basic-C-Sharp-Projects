using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create an abstract class called Person with two properties: string firstName and string lastName. DONE
            //2. Give it the method SayName(). DONE
            //3. Create another class called Employee and have it inherit from the Person class. DONE
            //4. Implement the SayName() method inside of the Employee class. DONE
            //5. Inside the Main() method, instantiate an Employee object with firstName "Sample" and lastName "Student". Call the SayName() method on the object.
            Employee em1 = new Employee() { FirstName = "Sample", LastName = "Student" };
            em1.SayName();
            Console.ReadLine();
        }
    }
}
