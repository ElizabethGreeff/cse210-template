using System;

class ChecklistGoal : Goal
{
    private int _ammountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _ammountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _ammountCompleted++;

        Console.WriteLine($"You earned {GetPoints()} points!");
        
        if (_ammountCompleted >= _target)
        {
            Console.WriteLine($"Goal completed! You earned {_bonus} extra points!");
        }
    }

    public override bool IsComplete()
    {
        return _ammountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $" {_ammountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_target}|{_bonus}|{_ammountCompleted}";
    }

    public int GetBonus()
    {
        return _bonus;
    }
}