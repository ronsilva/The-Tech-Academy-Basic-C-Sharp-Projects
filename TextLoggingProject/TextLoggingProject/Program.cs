using System;
using System.IO;

namespace TextLoggingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Ask a user for a number.
            Console.Write("Please enter a number: ");
            string userNumber = Console.ReadLine();
            //2.Log that number to a text file.
            File.WriteAllText(@"userNumber.txt", userNumber);
            //3.Print the text file back to the user.
            Console.WriteLine("You entered: {0}", File.ReadAllText(@"userNumber.txt"));
            Console.ReadLine();
        }    
    }
}
