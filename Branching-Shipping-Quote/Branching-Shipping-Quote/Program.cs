using System;

class Program
{
    static void Main()
    {
        //The first line of the program must be: “Welcome to Package Express. Please follow the instructions below.”
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        Console.WriteLine("*******************************************************************");
        //The user must then be prompted for the package weight.
        Console.WriteLine("What is weight of the package?");
        int packageWeight = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("*******************************************************************");
        //If the weight is greater than 50, display the error message, “Package too heavy to be shipped via Package Express.Have a good day.” At this point the program would end.
        if (packageWeight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            Console.ReadLine();
        }
        //The user must then be prompted for the package width.
        else
        {
            Console.WriteLine("What is the package width?");
        }
        int packageWidth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("*******************************************************************");
        //Then the package height.
        Console.WriteLine("What is the package height?");
        int packageHeight = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("*******************************************************************");
        //Then the package length.
        Console.WriteLine("What is the package length?");
        int packageLength = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("*******************************************************************");
        //If the sum of the dimensions is greater than 50, display the error message, “Package too big to be shipped via Package Express.” At this point the program would end.
        int totalDem = packageHeight + packageLength + packageWidth;
        if (totalDem > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            Console.WriteLine("*******************************************************************");
        }
        //The sum total of dimensions are then multiplied by the weight and divided by 100.
        //The result of that calculation is the quote.
        else
        {
        //Display the quote to the user as a dollar amount.
            decimal quote = totalDem * packageWeight / 100;
            Console.WriteLine("Your shipping quote is: $" + quote);
            Console.WriteLine("*******************************************************************");
        }
        Console.ReadLine();
    }
}

