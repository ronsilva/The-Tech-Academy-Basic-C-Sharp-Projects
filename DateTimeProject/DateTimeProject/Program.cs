using System;

namespace DateTimeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Prints the current date and time to the console.
            Console.WriteLine(DateTime.Now);
            //2.Asks the user for a number.
            Console.Write("Enter a number: ");
            double dub = Convert.ToInt32(Console.ReadLine());
            //3.Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
            Console.WriteLine(DateTime.Now.AddHours(dub));
            Console.ReadLine();
        }
    }
}
