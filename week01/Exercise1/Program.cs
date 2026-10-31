using System;

class Program
{
    static void Main(string[] args)
    {
        //This program ask the user for their fist and last name, and then displays it on the screen the way that James Bond introduces himself
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.Write("What is your fist name? ");
        string fName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lName = Console.ReadLine();
        Console.WriteLine($"Your name is {lName}, {fName} {lName}");
    }
}