using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();
        int number = -1;

        Console.WriteLine("Create your list of numbers, type 0 when finished. ");
        do
        {
            Console.Write("Enter a number: ");
            string userNumber = Console.ReadLine();
            number = int.Parse(userNumber);

            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        int i = 0;
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;

            if (num > i)
            {
                i = num;
            }
        }

        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {i}");
    }
}