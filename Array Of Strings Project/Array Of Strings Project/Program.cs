using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //1.0 Create an array of strings.
        string[] animals = new string[] { "Cats", "Dogs", "Bunnies", "Horses", "Birds", "Foxes" };

        //1.1 Ask the user to select an index of the Array and
        Console.WriteLine("Please select a number from 0 - 5: ");
        int arraySelect = Convert.ToInt32(Console.ReadLine());
        while (arraySelect > (animals.Length - 1))
        {
            if (arraySelect > (animals.Length - 1))
            {
                Console.WriteLine("What was that?  Please keep it between 0 - " + (animals.Length - 1));
                arraySelect = Convert.ToInt32(Console.ReadLine());

            }
        }
        
        //1.2 Then display the string at that index on the screen.
        Console.WriteLine("***********************************************************\n" + animals[arraySelect] + "\n***********************************************************");
        //2.0 Create an array of integers. 
        int[] aStringOfNumbers = { 5, 0, 8, 200, 600, 1000, 9000, 80, 75 };

        //2.1 Ask the user to select an index of the Array and 
        Console.WriteLine("Please select a number from 0 - 8:");
        arraySelect = Convert.ToInt32(Console.ReadLine());
        while (arraySelect > (aStringOfNumbers.Length - 1))
        {
            if (arraySelect > (aStringOfNumbers.Length -1))
            {
                Console.WriteLine("What was that?  Please keep it between 0 - " + (aStringOfNumbers.Length - 1));
                arraySelect = Convert.ToInt32(Console.ReadLine());

            }
        }

        //2.2 Then display the integer at that index on the screen.
        Console.WriteLine("***********************************************************\n" + aStringOfNumbers[arraySelect] + "\n***********************************************************");

        //3.Add in a message that displays when the user selects an index that doesn’t exist.
        //Applied with correct booliean ligic to above formulas.
        //while (true == true)
        //{
        //    if (false == false )
        //    {
        //        Console.WriteLine("What was that?  Please keep it between 0 - " + (var.length - 1));
        //        arraySelect = Convert.ToInt32(Console.ReadLine());

        //    }
        //}

        //4.0 Create a List of strings. 
        List<string> planets = new List<string>();
        planets.Add("Mercury");
        planets.Add("Venus");
        planets.Add("Earth");
        planets.Add("Mars");
        planets.Add("Jupeter");
        planets.Add("Saturn");
        planets.Add("Uranus");
        planets.Add("Neptune");
        planets.Add("Pluto");


        //4.1 Ask the user to select an index of the List and 
        Console.WriteLine("Please select a number from 0 - 8:");
        int listSelect = Convert.ToInt32(Console.ReadLine());
        while (listSelect > (planets.Count - 1))
        {
            if (listSelect > (planets.Count - 1))
            {
                Console.WriteLine("What was that?  Please keep it between 0 - " + planets.Count);
                listSelect = Convert.ToInt32(Console.ReadLine());

            }
        }
        //4.2 Then display the content at that index on the screen.
        Console.WriteLine("***********************************************************\n" + planets[listSelect] + "\n***********************************************************");
        Console.WriteLine();
        Console.ReadLine();
    }
}