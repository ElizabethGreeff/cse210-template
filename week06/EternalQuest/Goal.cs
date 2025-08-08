using System;
using System.Dynamic;
using System.Security.Principal;

abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    //Called when an even is recorded.
    public abstract void RecordEvent();

    //Wheather the goal is complete or not (for eternal goals, this remains false).
    public abstract bool IsComplete();
    //String used to save and load.
    public abstract string GetStringRepresentation();

    //Returns details string.
    public virtual string GetDetailsString()
    {
        return $"{_name} - {_description}";
    }

    public int GetPoints()
    {
        return _points;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }
}