using System;
using System.Net;
using System.Reflection;
using System.Text;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private int _level = 1;

    public void Start()
    {
        int choice = 0;

        while (choice != 7)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Show Score");
            Console.WriteLine("7. Quit");

            Console.Write("Choose an option: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                CreateGoal();
            }
            else if (choice == 2)
            {
                ListGoalDetails();
            }

            else if (choice == 3)
            {
                SaveGoals();
            }

            else if (choice == 4)
            {
                LoadGoals();
            }

            else if (choice == 5)
            {
                RecordEvent();
            }

            else if (choice == 6)
            {
                ShowScore();
            }
        }
    }

    private void CreateGoal()
    {
        //Clearing console for beter viewing
        Console.Clear();
        Console.WriteLine("\nTypes of Goals:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type would you like? ");
        int type = int.Parse(Console.ReadLine());

        Console.Write("\nName: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string description = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }

        else if (type == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }

        else if (type == 3)
        {
            Console.Write("Target Completions: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    private void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count(); i++)
        {
            Goal goal = _goals[i];
            string status = goal.IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{i + 1}. {status} {goal.GetDetailsString()}");
        }
    }

    private void RecordEvent()
    {
        Console.WriteLine("\nSelect a goal:");
        for (int i = 0; i < _goals.Count(); i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDescription()}");
        }
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count())
        {
            _goals[index].RecordEvent();
            _score += _goals[index].GetPoints();

            if (_goals[index] is ChecklistGoal checklist && checklist.IsComplete())
            {
                _score += checklist.IsComplete() ? checklist.GetPoints() : 0;
                _score += checklist.GetBonus();
            }
        }
    }

    private void SaveGoals()
    {
        using (StreamWriter output = new StreamWriter("goals.txt"))
        {
            output.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved!");
    }

    private void LoadGoals()
    {
        _goals.Clear();
        string[] lines = File.ReadAllLines("goals.txt");
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");
            string type = parts[0];

            if (type == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                if (bool.Parse(parts[4])) { goal.RecordEvent(); }
                _goals.Add(goal);
            }

            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }

            else if (type == "ChecklistGoal")
            {
                ChecklistGoal goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                for (int count = 0; count < int.Parse(parts[6]); count++)
                {
                    goal.RecordEvent();
                }
                _goals.Add(goal);
            }
        }
        Console.WriteLine("Goals Loaded!");
    }

    //addtional creativity, add levels.
    private void CheckLevel()
    {
        int newLevel = (_score / 1000) + 1;
        if (newLevel > _level)
        {
            _level = newLevel;
            Console.WriteLine($"\nCongratulations! You leveled up to level {_level}!");
        }

    }

    private void ShowScore()
    {
        CheckLevel();
        Console.WriteLine($"\nScore: {_score} | Level: {_level}");
    }
}