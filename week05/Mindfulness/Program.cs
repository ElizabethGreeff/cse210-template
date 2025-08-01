using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "";

        while (input != "5")
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("------------------");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Listing Activity");
            Console.WriteLine("3. Start Reflecting Activity");
            Console.WriteLine("4. Start Gratitude Activity");
            Console.WriteLine("5. Quit");
            Console.Write("Select an option (1-5): ");
            input = Console.ReadLine();

            if (input == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
                //Added a beep to show when users should inhale / exhale
            }
            if (input == "2")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
            if (input == "3")
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();
            }
            if (input == "4")
            {
                //Added a new activity to let the user reflect on things that bring them joy.
                GratitudeActivity activity = new GratitudeActivity();
                activity.Run();
            }
        }
    }
}