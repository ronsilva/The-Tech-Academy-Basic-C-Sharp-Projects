using System;

class Program
{
    static void Main()
    {
        //1.Do a boolean comparison using a while statement.

        Console.WriteLine("Guess a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        bool isAnswer = num > 30 || num < 50;

        while (isAnswer)
        {   
            if (num < 30)
            {
                Console.WriteLine("Nope, a little higher.");
                Console.WriteLine("Try another number:");
                num = Convert.ToInt32(Console.ReadLine());
            }
            else if (num > 50)
            {
                Console.WriteLine("Too much, less than that.");
                Console.WriteLine("Try another number:");
                num = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("That will work!");
                break;
            }
        }

        //2.Do a boolean comparison using a do while statement.
        Console.WriteLine("***********************************");
        Console.WriteLine("Let's guess another number:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        bool isAnswer2 = num > 30 || num < 50;

        do
        {
            if (num2 < 30)
            {
                Console.WriteLine("Nope, a little higher.");
                Console.WriteLine("Try another number:");
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            else if (num2 > 50)
            {
                Console.WriteLine("Too much, less than that.");
                Console.WriteLine("Try another number:");
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("That will work!");
                Console.ReadLine();
                break;
            }
        }

        while(isAnswer2);
    }
}

