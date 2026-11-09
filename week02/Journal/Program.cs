using System;
using System.Reflection.Metadata;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");


        Journal newJournal = new Journal();
        PromptGenerator newPrompt = new PromptGenerator();

        DateTime todayDate = DateTime.Now;
        string dateToString = todayDate.ToShortDateString();

        newPrompt._prompts.Add("What was the best part of your day?");
        newPrompt._prompts.Add("What is one thing I learned today?");
        newPrompt._prompts.Add("Who is one person I helped today?");
        newPrompt._prompts.Add("What was the strongest emotion I felt today?");
        newPrompt._prompts.Add("What is one thing I could do better tomorrow?");
        newPrompt._prompts.Add("What is the funniest thing that happened today?");
        newPrompt._prompts.Add("How did I see the hand of the Lord in my life today?");
        newPrompt._prompts.Add("If I had one thing I could do over today, what would it be?");
        newPrompt._prompts.Add("Who was the most interesting person I interacted with today?");

        int userChoice = 0;
        while (userChoice != 5)
        {
            Console.WriteLine();
            Console.WriteLine("1) Write");
            Console.WriteLine("2) Display");
            Console.WriteLine("3) Load");
            Console.WriteLine("4) Save");
            Console.WriteLine("5) Quit");

            Console.Write("What would you like to do? ");
            userChoice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Give user a prompt
            if (userChoice == 1)
            {
                Entry newEntry = new Entry();
                string prompt = newPrompt.GetRandomPrompt();
                newEntry._promtText = prompt;
                newEntry._date = dateToString;

                Console.WriteLine(prompt);
                Console.Write("> ");
                newEntry._entryText = Console.ReadLine();

                newJournal.AddEntry(newEntry);
            }

            // Display what they just entered
            else if (userChoice == 2)
            {
                newJournal.DisplayAll();
            }

            // Load jorunal from file
            else if (userChoice == 3)
            {
                Console.Write("What is the file name? ");
                string fileName = Console.ReadLine();
                newJournal.LoadFromFile(fileName);
            }

            // Save journal to a file
            else if (userChoice == 4)
            {
                Console.Write("What is the file name? ");
                string fileName = Console.ReadLine();
                newJournal.SaveToFile(fileName);
            }
        }
    }
}
