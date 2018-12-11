using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonW2Params
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a class called Person and give it two properties, each of data type string. One called FirstName, the other LastName. DONE
            //2. Give this class a void method called SayName() that takes no parameters and simply writes the person's full name to the console in the format of: "Name: [full name]". DONE
            //3.0 Create another class called Employee and have it inherit from the Person class. DONE
            //3.1 Give the Employee class a property called Id and have it be of data type int. DONE
            //4. Inside of the Main method, instantiate and initialize an Employee object with a first name of "Sample" and a last name of "Student". DONE
            Employee em1 = new Employee() { FirstName = "Sample", LastName = "Student" };
            //5. Call the superclass method SayName() on the Employee object. DONE
            em1.SayName();
            Console.ReadLine();
        }
    }
}
