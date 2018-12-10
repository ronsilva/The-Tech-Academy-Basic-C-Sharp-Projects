using System;

namespace MethodWithOptionalParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.0 Create a class. DONE
            //1.1 In that class, create a method that takes two integers as parameters. DONE
            //1.2 Make one of them optional. DONE
            //1.3 Have the method do a math operation and return a integer result. DONE
            //2.0 In the Main() method of the console app, instantiate the class. DONE
            MOWOpParam mo = new MOWOpParam();
            //3.0 Ask the user to input two numbers, one at a time. DONE
            Console.WriteLine("Please enter a number: ");
            int num1  = Convert.ToInt32(Console.ReadLine());
            //3.1 Let them know they need not enter anything for the second number.
            Console.WriteLine("Optional: Enter another number: ");
            string tempAnswer = null;
            int tempNum = 0;
            //5.0 Try various combinations of numbers on the code, including having no second number. DONE
            try
            {
                tempAnswer = Console.ReadLine();
                tempNum = Convert.ToInt32(tempAnswer);
            }
            catch(Exception)
            {

            }
            int num2 = tempNum;
            int total;
            //4.0 Call the method in the class, passing in the one or two numbers entered. DONE
            if (tempAnswer == null)
            {
               total = mo.MOMath(num1);
               Console.WriteLine("Your total is: {0}.", total);
            }
            else
            {
               total = mo.MOMath(num1, num2);
               Console.WriteLine("Your total is: {0}. which is also your secound number: {1}", total, num2);
            }
            Console.ReadLine();
        }
    }
}
