using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAClass_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.0 Create a class. DONE 
            //1.1 In that class, create three methods, each of which will take one integer parameter in and return an integer. DONE
            //1.2 The methods should do some math operation on the received parameter. Put this class in a separate.cs file in the application. DONE
            //2.0 In the Main() program, ask the user what number they want to do the math operations on.
            Console.WriteLine("Please Enter a Number to do some math with:");
            int num = Convert.ToInt32(Console.ReadLine());
            //3.0 Call each method in turn, passing the user input to the method.Display the returned integer to the screen.
            IntegerW3Methods mathWiz = new IntegerW3Methods();

            int answer1 = mathWiz.Add(num);
            int answer2 = mathWiz.Divide(num);
            int answer3 = mathWiz.Multiply(num);
            
            Console.WriteLine(answer1);
            Console.WriteLine(answer2);
            Console.WriteLine(answer3);
            
            Console.ReadLine();

        }
    }
}
