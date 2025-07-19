using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("Proverbs", 3, 5, 6);
        string text1 = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";
        Scripture scripture1 = new Scripture(reference1, text1);

        //Creative addition to do another scripture

        Reference reference2 = new Reference("2 Nephi", 2, 25);
        string text2 = "Adam fell that men might be; and men are, that they might have joy.";
        Scripture scripture2 = new Scripture(reference2, text2);

        while (!scripture1.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture1.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words, type 'quit' to exit, or type 'try another' to do another scripture.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            //Addition to do another scripture if desired

            else if (input.ToLower() == "try another")
            {
                while (!scripture2.AllWordsHidden())
                {
                    Console.Clear();
                    Console.WriteLine(scripture2.GetDisplayText());
                    Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
                    string input2 = Console.ReadLine();

                    if (input2.ToLower() == "quit")
                    {
                        break;
                    }

                    scripture2.HideRandomWords(3);
                }
            }

            scripture1.HideRandomWords(3);
        }
        Console.Clear();
        Console.WriteLine(scripture1.GetDisplayText());
        Console.WriteLine(scripture2.GetDisplayText());

    }
}