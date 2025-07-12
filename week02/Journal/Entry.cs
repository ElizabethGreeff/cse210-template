using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _entryFeel;

    public void Display()
    {
        Console.WriteLine($"\nDate: {_date} Prompt: {_promptText}: ");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine($"This had a {_entryFeel} impact on your day.");
    }
}