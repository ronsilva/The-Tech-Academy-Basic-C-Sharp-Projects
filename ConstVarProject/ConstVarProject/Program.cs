using System;

namespace ConstVarProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a const variable
            const string myName = "Ron Silva";
            Console.WriteLine("Hi! My name is {0}.", myName);
            //3.Chain two constructors together. DONE
            Console.Write("Please enter a plural noun: ");
            //2.Create a variable using the keyword "var".
            var answer = Console.ReadLine();
            GoodNumber gN = new GoodNumber(answer);
            Console.WriteLine("A good number of {0} is {1}.", gN.GoodFor, gN.Number);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Thanks for playing!");
            Console.ReadLine();
        }
    }
}
