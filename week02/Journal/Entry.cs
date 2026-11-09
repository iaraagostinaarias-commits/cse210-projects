public class Entry
{
    public string _date;

    public string _promtText;

    public string _entryText;

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promtText}");
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }
}
