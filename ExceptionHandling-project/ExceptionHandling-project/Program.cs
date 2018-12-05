using System;
class Program
{
    static void Main()
    {
        //1.0 Create a list of integers.-- DONE
        int[] divisors = new int[10] { 2, 5, 6, 81, 84, 24, 20, 16, 51, 87 };
        try
        {
            //1.1 Ask the user for a number to divide each number in the list by.
            Console.WriteLine("We are going to do some division: \nPlease enter a number: ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("******************************************************");
            //1.2 Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen. 
            for (int i = 0; i < divisors.Length; i++)
            {
                int quotent = divisors[i] / dividend;

                Console.WriteLine(i + 1 + ".  " + divisors[i] + " / " + dividend + " = " + quotent);
            }

            Console.ReadLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
        finally
        {
            Console.WriteLine("\n************************************************************");
            Console.WriteLine("That's all fokes!");
            Console.ReadLine();
        }
        //2.Run that code, entering in non - zero numbers as the user.Look at the displayed results.
        //DONE
        //3.Run that code, entering in zero as the number to divide by.Note any error messages you get.
        //DONE
        //4.Run that code, entering in a string as the number to divide by.Note any error messages you get.
        //DONE
        //5.Now put the loop in a try/catch block. Below and outside of the try/catch block, make the program display a message to the display to let you know the 
        //program has emerged from the try/catch block and continued on with program execution.In the catch block, display the error message to the screen.
        //Then try various combinations of user input: valid numbers, zero and a string.Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.
Console.WriteLine("We made it out of that!");
        Console.ReadLine();
    }
}