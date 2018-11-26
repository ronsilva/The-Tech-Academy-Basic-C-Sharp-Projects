using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Do you qualify?");
        Console.WriteLine("*****************************************************");
        //What is your age ?
        Console.WriteLine("What is your age?");
        string applicantAge = Console.ReadLine();
        Console.WriteLine("*****************************************************");
        //Have you ever had a DUI?
        Console.WriteLine("Have you ever had a DUI? Please type 'Yes or No'");
        string DUIs = Console.ReadLine();
        string wrongAnswer = "Yes";
        bool applicantDUIs = DUIs == wrongAnswer;
        Console.WriteLine("*****************************************************");
        //How many speeding tickets do you have?
        Console.WriteLine("How many speeding tickets do you have?");
        string applicantTickets = Console.ReadLine();
        Console.WriteLine("*****************************************************");
        //Applicants must be over 15 years old.
        //Applicants must not have any DUI’s.
        //Applicants must not have more than 3 speeding tickets.
        bool isApproved = Convert.ToInt32(applicantAge) > 15 && applicantDUIs == false && Convert.ToUInt32(applicantTickets) <= 3;
        Console.WriteLine(isApproved);
        Console.ReadLine();
    }
}

