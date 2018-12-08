using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodClass_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.0 Create a class. In that class, create a void method that takes two integers as parameters. DONE
            //1.1 Have the method do a math operation on the first integer and display the second integer to the screen. DONE
            //2. In the Main() method of the console app, instantiate the class. DONE
            VoidMethod instance1 = new VoidMethod();
            //3. Call the method in the class, passing in two numbers. DONE
            instance1.DoACoupleOfThings(5, 60);
            //4. Call the method in the class, specifying the parameters by name. DONE
            instance1.DoACoupleOfThings(num1: 5, num2: 60);
        }
    }
}
