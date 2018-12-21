using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Ask the user for his age.
            //3.Exceptions must be handled using "try .. catch".
            Console.Write("Hi! ");
            bool validAnswer = false;
            int age = 0;
            while (!validAnswer)
            {
                try
                {
                    Console.Write("Please enter you age: ");
                    age = Convert.ToInt32(Console.ReadLine());
                    if (age <= 0)
                    {
                        //4.Display appropriate error messages if user enters zero or negative numbers.
                        throw new ArgumentException();
                    }
                    if (age <= 18)
                    {
                        //2.Display the year user born.
                        validAnswer = true;
                        var thisYear = DateTime.Now.Year;
                        var yearBorn = thisYear - age;
                        Console.WriteLine("You're a young'n!");
                        Console.WriteLine("If you have not had your birthday this year, you where born in: {0}. \nOtherwise your birthyear was: {1}", yearBorn, yearBorn - 1);
                        Console.ReadLine();
                    }
                    if (age >= 18)
                    {
                        //2.Display the year user born.
                        validAnswer = true;
                        var thisYear = DateTime.Now.Year;
                        var yearBorn = thisYear - age;
                        Console.WriteLine("If you have not had your birthday this year, you where born in: {0}. \nOtherwise your birthyear was: {1}", yearBorn, yearBorn - 1);
                        Console.ReadLine();
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Please enter a number greater than 0.");
                }
                catch (Exception)
                {
                    //5.Display a general message if exception caused by anything else.
                    Console.WriteLine("Please enter your age as a whole number only.\n********************************************");
                }
            }
        }
    }
}
