using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //1.0 Create a one-dimensional Array of strings.
        string[] cities = new string[] { "Houston", "Portland", "Dallas", "Plano", "Irvine", "Los Angeles", "Clearwater", "Tampa", "Miami" };

        //1.1 Ask the user to input some text.
        Console.WriteLine("Enter one thing that you like (For example \"Cars\" or \"Pizza\"):");
        string respose1 = Console.ReadLine();
        Console.WriteLine("Now enter what you like doing with that (For example \"Drive\" or \"Eat\"):");
        string respose2 = Console.ReadLine();

        //1.2 Create a loop that goes through each string in the Array, adding the user’s text to the string.
        for (int i = 0; i < cities.Length; i++)
        {
            Console.WriteLine("I like to " + respose2 + " " + respose1 + " in " + cities[i]);
        }
        Console.WriteLine("And now for my next trick press enter*****************");
        Console.ReadLine();
        Console.Clear();
        //1.3 Then create a loop that prints off each string in the Array on a separate line.
        Console.WriteLine("Here are some cities I have visted:");
        for (int i = 0; i < cities.Length; i++)
        {
            Console.WriteLine(cities[i]);
        }
        Console.WriteLine("And now for my next trick press enter*****************");
        Console.ReadLine();
        Console.Clear();
        //2.Create an infinite loop.
        while (7 > 6)
            {
                Console.WriteLine("I'm going to go on forever");
                break; // <-- 3.Fix the infinite loop so it will execute.
        }
        Console.WriteLine("Or maybe not... Moving on. Please press enter *****************");
        Console.ReadLine();
        Console.Clear();
        //4.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.
        int snap = 1000;
        for (int i = 0; i < snap; i++)
        {
            Console.WriteLine("Let's count to 1000: " + i);
        }
        Console.WriteLine("Awe Snap! short by 1!");
        Console.WriteLine("And now ... well you know *****************");
        Console.ReadLine();
        Console.Clear();
        //5.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
        int what = 0;
        for (int j = 999; j >= what; j--)
        {
            Console.WriteLine("Let's count down from 999: " + j);
        }
        Console.WriteLine("What!!! All the way to 0!");
        Console.WriteLine("Now time to do your thang! ... No not that! Just press enter *****************");
        Console.ReadLine();
        Console.Clear();
        
        //6.0 Create a List of strings where each item in the list is unique.
        List<string> uniqueList = new List<string>();
        uniqueList.Add("White Peacocks");
        uniqueList.Add("Bismuth Crystals");
        uniqueList.Add("The Insides of a Meteorite");
        uniqueList.Add("Jeweled Squid");
        uniqueList.Add("Life Within Death");
        uniqueList.Add("Rafflesia arnoldi Flower");
        uniqueList.Add("Purple Carrots");
        uniqueList.Add("Auroras");
        uniqueList.Add("Rain as seen from an airplane window");
        uniqueList.Add("Kangaroo joey Inside the Pouch");
        uniqueList.Add("Red Banana");
        uniqueList.Add("Living Rock");
        uniqueList.Add("Tasmanian Giant Crab");
        uniqueList.Add("Purple Corn");
        uniqueList.Add("Koroit Opal");
        uniqueList.Add("Albino Alligator");
        uniqueList.Add("The Glowing Forest");
        uniqueList.Add("Flying Fish");
        uniqueList.Add("A Katydid camouflaging into its surroundings");
        uniqueList.Add("The Dragon's Skull");
        uniqueList.Add("Amazingly Beautiful Campo");
        uniqueList.Add("The Corpse Flower");
        uniqueList.Add("The Flying Gurnards");
        uniqueList.Add("Albino Humpback Whale");

        //Console.WriteLine("I did someting you just can't see it.");
        //Console.WriteLine("Now do the thing **************************");
        //Console.ReadLine();
        //6.1 Ask the user to select text to search for in the List.
        Console.WriteLine("See this link: \n24 Rarest of Rare Awesome Things Found on Earth Ever");
        Console.WriteLine("http://www.emlii.com/5c268a40/24-Rarest-of-Rare-Awesome-Things-Found-on-Earth-Ever \n");
        Console.WriteLine("Select any of this unique things from this list and type it in or just copy and paste. \n" +
            "(Ignore any part past a coma, parenthesis or colon)");
        string itemEntered = Console.ReadLine();
        //6.2 Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.
        
        // This prodduces the outcome...
        Console.WriteLine("You entered: " + itemEntered + " and the index position of that is: " + uniqueList.IndexOf(itemEntered));
        // of this step in the exercise.
        
        Console.WriteLine("Get ready for some deja vu ********** Press Enter!");
        Console.ReadLine();
        Console.Clear();

        //This is the long-ass way of doing the same as above:
        Console.WriteLine("*********************************************************\n" +
                          "******************This is not a glitch*******************\n" +
                          "*********************************************************");

        // Here I have the computer iterate through the list with a loop I made and print the index position based on a counter instead of asking for the IndexOf like above.
        Console.WriteLine("See this link: \n24 Rarest of Rare Awesome Things Found on Earth Ever");
        Console.WriteLine("http://www.emlii.com/5c268a40/24-Rarest-of-Rare-Awesome-Things-Found-on-Earth-Ever \n");
        Console.WriteLine("Select any of this unique things from this list and type it in or just copy and paste. \n" +
            "(Ignore any part past a coma, parenthesis or colon)");

        string itemEnteredAgain = Console.ReadLine();
        for (int counter = 0; counter < uniqueList.Count; counter++)
        {
            if (itemEnteredAgain != uniqueList[counter] && counter == uniqueList.Count - 1)
            {
                counter = -1;
                Console.WriteLine("Something was off a bit. let's try that again:");
                itemEnteredAgain = Console.ReadLine();
            }
            else if (itemEnteredAgain == uniqueList[counter])
            {
                Console.WriteLine("You entered: " + itemEnteredAgain + " and the index position of that is: " + counter);
                break;
            }
            
        }
        Console.WriteLine("Okay now moving on **************************");
        Console.ReadLine();
        Console.Clear();
        //7.Add code to that above loop that tells a user if they put in text that isn’t in the List. DONE
        //8.Add code to that above loop that stops it from executing once a match has been found. DONE

        //9.0 Create a List of strings that has at least two identical strings in the List. 
        List<string> animals = new List<string>() { "dog", "cat", "horse", "squid", "fish", "donkey", "squid", "cat", "horse", "cat" };
        
        //9.1 Ask the user to select text to search for in the List.
        Console.WriteLine("Let's pick an animal. for example: enter \"dog\" or \"cat\" to see if it's in the list.");
        
        //9.2 Create a loop that iterates through the list and 
        string animalSelected = Console.ReadLine();
        int w = 0;
        for (int counter = 0; counter < animals.Count; counter++)
        {
            if (animalSelected != animals[counter] && counter == animals.Count - 1 &&  w == 0)
            {
                Console.WriteLine("That's not on the list. Try again:");
                animalSelected = Console.ReadLine();
                counter = 0;
            }
            else if (animalSelected == animals[counter])
            {
                Console.WriteLine("You entered: " + animalSelected + " and the index of that is: " + counter);
                w = 1;
            }
        }
        //9.3 Then displays the indices of the array that contain matching text on the screen. DONE
        //10.Add code to that above loop that tells a user if they put in text that isn’t in the List. DONE
        Console.WriteLine("Well that was fun... One last thing before you go...");
        Console.ReadLine();
        Console.Clear();
        //11.0 Create a List of strings that has at least two identical strings in the List.
        List<string> names = new List<string>() { "Ron", "Bill", "Jack", "Donna", "Peter", "Nancy", "Johnny", "Ted", "Mike", "Heidi", "Luca", "Isabella", "Ron", "Bill", "Jack", "Donna", "Peter", "Nancy" };

        //11.1 Create a foreach loop that evaluates each item in the list, 
        Console.WriteLine("Here are a lidt of name:");
        foreach (string name in names)
        {
            for (int i = 1; i < names.Count; i++)
            {
                if (name == names[i])
                {
                    Console.WriteLine("Hi! my name is " + name + " and I have already intruduced myself.");
                }
            }
        }
        //11.2 and displays a message showing the string DONE 

        //11.3 and whether or not it has already appeared in the list.

        Console.ReadLine();
    }
}