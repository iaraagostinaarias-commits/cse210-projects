using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        // This program ask the user for their grade percentage, then displays what grade letter would that be and a message indicating if it pass the course or not

        // Promt to enter grade percentage
        Console.Write("What is your grade percentage? ");
        string userNumber = Console.ReadLine();

        // Variables declaration
        string letter = "";
        string symbol = "";
        int grade = int.Parse(userNumber);
        float reminder = grade % 10;

        // Assign grade letter section
        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        // Assign symbol section
        if (reminder >= 7)
        {
            symbol = "+";
        }
        else if (reminder < 3)
        {
            symbol = "-";
        }
        else
        {
            symbol = "";
        }

        if (letter == "F")
        {
            symbol = "";
        }

        // Display grades section
        Console.WriteLine($"Your grade letter is: {letter}{symbol}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed!!");
        }
        else
        {
            Console.WriteLine("Don't give up! You'll do it great next time!");
        }
    }
}