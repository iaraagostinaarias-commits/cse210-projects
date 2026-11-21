using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.WriteLine();

        Reference reference = new Reference("Moses", 6, 34);
        Scripture scripture = new Scripture(reference, "Behold my Spirit is upon you, wherefore all thy words will I justify; and the mountains shall flee before you, and the rivers shall turn from their course; and thou shalt abide in me, and I in you; therefore walk with me.");

        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.Write("Press enter to continue or type 'quit' to finish: ");
        string userInput = Console.ReadLine().ToLower();

        while (scripture.IsCompletelyHidden() != true)
        {
            if (userInput == "quit")
            {
                break;
            }

            else
            {
                scripture.HideRandomWords(2);
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
            }
            Console.WriteLine();
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine().ToLower();
        }
    }
}