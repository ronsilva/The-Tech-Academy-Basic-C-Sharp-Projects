using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");

        Console.WriteLine("What course are you on?");
        string nameOfCourse = Console.ReadLine();
        
        Console.WriteLine("What page number?");
        string currentPage = Console.ReadLine();
        int pageNum = Convert.ToInt16(currentPage);

        Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
        string needHelp = Console.ReadLine();
        bool helpnNeeded = Convert.ToBoolean(needHelp);

        Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
        string positiveExperiences = Console.ReadLine();

        Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
        string feedback = Console.ReadLine();

        Console.WriteLine("How many hours did you study today?");
        string hoursOfStudy = Console.ReadLine();
        int studyTime = Convert.ToInt16(hoursOfStudy);

        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly.Have a great day!");
        Console.Read();
    }
}
