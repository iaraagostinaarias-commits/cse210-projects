using System;

class Program
{
    static void Main(string[] args)
    {
        //This program ask the user for its fist and last name, and then displays it on the screen the way that James Bond introduces himself
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.Write("What is your fist name? ");
        string fname = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lname = Console.ReadLine();
        Console.WriteLine($"Your name is {lname}, {fname} {lname}");
    }
}