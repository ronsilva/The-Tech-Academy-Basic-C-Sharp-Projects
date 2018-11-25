using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 class Program
{
    static void Main()
    {
        //1.Takes an input from the user, multiplies it by 50, and prints the result to the console. (Note: make sure your code can take inputs larger than 10, 000, 000).
        Console.WriteLine("Please enter a number: ");
        string numToMultiply = Console.ReadLine();
        int multiplyTotal = Convert.ToInt32(numToMultiply) * 50;
        Console.WriteLine(numToMultiply + " x 50 = " + multiplyTotal);
        
        //2.Takes an input from the user, adds 25 to it, and prints the result to the console.
        Console.WriteLine("Please enter a another number: ");
        string numToAdd = Console.ReadLine();
        int addTotal = Convert.ToInt32(numToAdd) + 25;
        Console.WriteLine(numToAdd + " + 25 = " + addTotal);
        
        //3.Takes an input from the user, divides it by 12.5, and prints the result to the console.
        Console.WriteLine("Please enter a another number: ");
        string numToDivide = Console.ReadLine();
        double divideTotal = Convert.ToDouble(numToDivide) / 12.5;
        Console.WriteLine(numToDivide + " / 12.5 = " + divideTotal);
        
        //4.Takes an input from the user, checks if it is greater than 50, and prints the true / false result to the console.
        Console.WriteLine("Please enter a another number: ");
        string numToCheck = Console.ReadLine();
        bool checkedNum  = Convert.ToInt32(numToCheck) > 50;
        Console.WriteLine(numToCheck + " is greater than 50: " + checkedNum);
        
        //5.Takes an input from the user, divides it by 7, and prints the remainder to the console(tip: think % operator).
        Console.WriteLine("Please enter a another number: ");
        string numToDivideAgain = Console.ReadLine();
        double remainder = Convert.ToDouble(numToDivideAgain) % 7;
        Console.WriteLine(remainder + " is the remainder of "+ numToDivideAgain);
        Console.WriteLine("Thank you and come again! ;)");
        Console.ReadLine();
    }
}
