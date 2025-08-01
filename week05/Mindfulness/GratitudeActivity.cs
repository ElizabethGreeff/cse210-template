using System;
//Creative addition, extra activity.

class GratitudeActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Name a person you are thankful for and why.",
        "What is something about your body that you are thankful for?",
        "Think of a happy memory you are thankful for.",
        "What skill or ability are you gratful for today?",
        "Think of someething you often take for granted, but you would miss if it were gone.",
        "What is a recent memory that made you smile or laugh?",
        "What is something in nature that you appreciate?"
    };

    public GratitudeActivity() : base("Gratitude", "This activity will help you focus on positive aspects of your life by enchouraging you to express gratitude.")
    { }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count())];
    }

    public void Run()
    {
        DisplayStartMessage();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        Console.Clear();
        Console.WriteLine("Consider the following Promts. Take your time to reflect on these questions or jot them down if you would like.");

        while (DateTime.Now < endTime)
        {
            string prompt = GetRandomPrompt();
            Console.WriteLine($"> {prompt}");
            ShowSpinner(5);
            Console.WriteLine();
        }
        DisplayEndingMessage();
    }
}