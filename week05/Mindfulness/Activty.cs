using System;

class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    protected int GetDuration()
    {
        return _duration;
    }

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    protected void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"-- {_name} Activity --");
        Console.WriteLine($"{_description}");
        Console.WriteLine("Enter a duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nGet ready to start...");
        ShowSpinner(3);
    }
    protected void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed the {_name} Activity for {_duration} seconds!");
        ShowSpinner(3);
    }
    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write(spinner[i % 4]);
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }
    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();        
    }
}
