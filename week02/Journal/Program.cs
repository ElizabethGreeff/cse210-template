using System;
//Additional Creativity: Added kind sendoff and display's entry count. Added Positive and Negative impact 
//analysis to show if a user had a good / bad day based on daily impact.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the journal program!");
        string userChoice = "";
        Journal newJournal = new Journal();

        while (userChoice != "5")
        {
            Console.WriteLine("Please enter one of the following choices (in numerical form) :");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? : ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Entry newEntry = new Entry();
                PromptGenerator newPrompt = new PromptGenerator();
                DateTime dateTimeNow = DateTime.Now;
                string dateText = dateTimeNow.ToShortDateString();
                newEntry._date = dateText;
                newEntry._promptText = newPrompt.GetRandomPrompt();
                Console.WriteLine($"{newEntry._promptText}");
                Console.Write("> ");
                newEntry._entryText = Console.ReadLine();
                // additional creativity, used to estimate a good or bad day
                Console.WriteLine("Did this have a \nNegative \nor \nPositive \nimpact on your day?");
                Console.Write(">");
                newEntry._entryFeel = Console.ReadLine();
                newJournal.AddEntry(newEntry);
            }
            if (userChoice == "2")
            {
                newJournal.DisplayAll();
            }
            if (userChoice == "3")
            {
                Console.WriteLine("Please enter the file you would like to load from:");
                Console.Write(">");
                string filename = Console.ReadLine();
                newJournal.LoadFromFile(filename);
            }
            if (userChoice == "4")
            {
                Console.WriteLine("Please add a filename:");
                Console.Write("> ");
                string filename = Console.ReadLine();
                newJournal.SaveToFile(filename);
            }
        }
        //Additional creativity, kind send off.
        Console.WriteLine("Thanks for taking the time to write, see you next time!");
    }
}