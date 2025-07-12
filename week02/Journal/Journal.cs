using System;
using System.Security.Cryptography;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        //additional creativity, gives user ability to see entry count.
        Console.WriteLine($"Entries count: {_entries.Count}");
    }
    public void DisplayAll()
    {
        if (_entries.Count > 0)
        {
            int dayImpact = 0;
            foreach (Entry entry in _entries)
            {
                entry.Display();
                // Additional creativity, finds the average good/bad impact in user day.
                if (entry._entryFeel == "Positive")
                {
                    dayImpact += 1;
                }
                else if (entry._entryFeel == "Negative")
                {
                    dayImpact -= 1;
                }
            }
            // Additional creativity, added support or good and bad days
            float average = ((int)dayImpact) / _entries.Count;
            if (dayImpact >= average)
            {
                Console.WriteLine("Your day has beed good! You have had more Positive experiences!\n");
            }
            if (dayImpact < average)
            {
                Console.WriteLine("Your day hasn't been great, but it will be better, don't worry.\n");
            }
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("You have no entries, try write one or load from a save file!");
            Console.WriteLine("");
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputfile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText},{entry._entryFeel}");
            }
        }
    }
    public void LoadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string date = parts[0];
            string prompt = parts[1];
            string entry = parts[2];
            string impact = parts[3];

            Entry loadEntry = new Entry();
            loadEntry._date = date;
            loadEntry._promptText = prompt;
            loadEntry._entryText = entry;
            loadEntry._entryFeel = impact;

            _entries.Add(loadEntry);
        }
    }
}