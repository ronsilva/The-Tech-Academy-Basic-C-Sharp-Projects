using System;

class Program
{
    static void Main()
    {
        //The program must start by printing “Anonymous Income Comparison Program” to the screen.
        Console.WriteLine("Anonymous Income Comparison Program");
        Console.WriteLine("*************************************************");
        //It must then print “Person 1” to the screen and get the following details:
        //Hourly Rate
        //Hours worked per week
        decimal hourlyRatePer1 = 25m;
        int hoursWorkedPerWeekPer1 = 45;
        Console.WriteLine("Person 1");
        Console.WriteLine("Hourly Rate = " + hourlyRatePer1);
        Console.WriteLine("Hours Per Week = " + hoursWorkedPerWeekPer1);
        Console.WriteLine("*************************************************");
        //It must then print “Person 2” to the screen and then get the following details:
        //Hourly rate
        //Hours worked per week
        decimal hourlyRatePer2 = 50m;
        int hoursWorkedPerWeekPer2 = 40;
        Console.WriteLine("Person 2");
        Console.WriteLine("Hourly Rate = " + hourlyRatePer2);
        Console.WriteLine("Hours Per Week = " + hoursWorkedPerWeekPer2);
        Console.WriteLine("*************************************************");
        //It must then print to the screen “Annual salary of Person 1:” and write the exact salary below it.
        decimal annualSalaryPer1 = hourlyRatePer1 * hoursWorkedPerWeekPer1 * 52;
        Console.WriteLine("Annual salary of Person 1: " + annualSalaryPer1);
        //It must then print to the screen “Annual salary of Person 2:” and write the exact salary below it.
        decimal annualSalaryPer2 = hourlyRatePer2 * hoursWorkedPerWeekPer2 * 52;
        Console.WriteLine("Annual salary of Person 2: " + annualSalaryPer2);
        Console.WriteLine("*************************************************");
        //It must then print to the screen “Does Person 1 make more money than Person 2 ?” and write the true or false value of this statement below it.
        bool doesPerson1MakeMoreThanPerson2 = annualSalaryPer1 > annualSalaryPer2;
        Console.WriteLine("Does Person 1 make more money than Person 2? " + doesPerson1MakeMoreThanPerson2);
        Console.ReadLine();
    }
}
