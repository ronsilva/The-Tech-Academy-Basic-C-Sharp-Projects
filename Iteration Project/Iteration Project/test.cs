using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        //11.0 Create a List of strings that has at least two identical strings in the List.
        List<string> names = new List<string>() { "Ron", "Bill", "Jack", "Donna", "Peter", "Nancy", "Johnny", "Ted", "Mike", "Heidi", "Luca", "Isabella", "Ron", "Bill", "Jack", "Donna", "Peter", "Nancy" };

        //11.1 Create a foreach loop that evaluates each item in the list, 
        Console.WriteLine("Here is a list of names:");
        foreach (string name in names)
        {
            Console.WriteLine();
        }
        //11.2 and displays a message showing the string DONE 
        //11.3 and whether or not it has already appeared in the list.

        Console.ReadLine();
    }
 
}