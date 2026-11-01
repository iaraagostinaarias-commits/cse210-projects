using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        Console.WriteLine("Guess the magic number! (between 1-100) ");
        Console.Write("What is your guess? ");
        string userGuess = Console.ReadLine();
        int userNumber = int.Parse(userGuess);

        while (userNumber != magicNumber)
        {
            if (userNumber > magicNumber)
            {
                Console.WriteLine("Try lower");
                Console.Write("What is your guess? ");
                userGuess = Console.ReadLine();
                userNumber = int.Parse(userGuess);
            }
            else
            {
                Console.WriteLine("Try higher");
                Console.Write("What is your guess? ");
                userGuess = Console.ReadLine();
                userNumber = int.Parse(userGuess);
            }
        }

        Console.WriteLine("Congrats, you guessed the number!");
    }
}