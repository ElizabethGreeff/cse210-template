using System;

class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people you have helped this week?",
        "When have you felt the Holy Ghost this week?",
        "Who are some of your persnal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many positive things as you can.")
    { }
    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count())];
    }
    private List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                responses.Add(input);
            }
        }
        return responses;
    }
    public void Run()
    {
        DisplayStartMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine("You may begin listing in:");
        ShowCountDown(3);
        Console.WriteLine("Go!");

        List<string> list = GetListFromUser();
        _count = list.Count();

        Console.WriteLine($"\nYou listed {_count} items.");
        DisplayEndingMessage();
    }
}