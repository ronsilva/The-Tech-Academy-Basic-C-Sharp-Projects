using System;
namespace EnumDaysOfTheWeek
{
    class Program
    {
        //1.Create an enum for the days of the week. DONE
        enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Satusrday,
            Sunday,
        };
        static void Main()
        {
            //2. Prompt the user to enter the current day of the week.
            Console.Write("Please enter the current day of the week: ");
            //3. Assign the value to a variable of that enum data type you just created.
            Days days = new Days();
            string answer = Console.ReadLine().ToLower();
            //4. Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week." to the console if an error occurs.
            try
            {
                foreach (Days day in (Days[])Days.GetValues(typeof(Days)))
                {
                    string sDay = day.ToString().ToLower();
                    if (answer == sDay && sDay == DateTime.Now.DayOfWeek.ToString().ToLower())
                    {
                        Console.WriteLine("That's right it's {0}", DateTime.Now.DayOfWeek);
                    }
                    else if (answer == sDay && sDay != DateTime.Now.DayOfWeek.ToString().ToLower())
                    {
                        Console.WriteLine("Today is not {0}", sDay);
                        Console.WriteLine("Today is {0}", DateTime.Now.DayOfWeek);
                    }
                }
            }
            catch (Exception ex) { }
            finally
            {
                Console.WriteLine("Please enter an actual day of the week: ");
            }
                Console.ReadLine();
            //Note - In the last video, we explained the underlying concepts behinds enums. Nobody knows everything about a programming language and its features, 
            //so it's our job as programmers to do research on how to work with various data types, classes and libraries. For this drill, 
            //you'll need to do some additional research on how to parse enums.
        }
    }
}