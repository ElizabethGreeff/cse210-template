using System;

public class PromptGenerator
{

    public List<string> _prompts;

    public string GetRandomPrompt()
    {
        _prompts = new List<string>();
        
        string filename = "prompts.txt";
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            _prompts.Add(line);
        }
        Random random = new Random();
        int i = random.Next(_prompts.Count);
        return _prompts[i];

    }
}