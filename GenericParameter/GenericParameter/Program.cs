using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Make the Employee class take a generic type parameter. DONE
            //2. Add a property to the Employee class called "things" and have its data type be a generic list matching the generic type of the class. DONE
            //3.0 Instantiate an Employee object with type "string" as its generic parameter.
            Employee<string> em1 = new Employee<string>();
            em1.Things = new List<string>();
            //3.1 Assign a list of strings as the property value of Things. DONE
            em1.Things.Add("Mug");
            em1.Things.Add("Pens");
            em1.Things.Add("Baskets");
            em1.Things.Add("Stapler");
            em1.Things.Add("Staples");
            em1.Things.Add("Paper");
            //4.0 Instantiate an Employee object with type "int" as its generic parameter. DONE
            Employee<int> em2 = new Employee<int>();
            em2.Things = new List<int>();
            //4.1 Assign a list of integers as the property value of Things. DONE
            em2.Things.Add(5);
            em2.Things.Add(12);
            em2.Things.Add(90);
            em2.Things.Add(60);
            em2.Things.Add(53);
            em2.Things.Add(25);
            //5. Create a loop that prints all of the Things to the Console.
            Console.WriteLine("Employee 1's things:");
            foreach (string thing in em1.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
            Console.WriteLine("Employee 2's numbers:");
            foreach (int thing in em2.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
