using System;

public class Shape
{
    string _colour;

    public Shape(string colour)
    {
        SetColour(colour);
    }

    public string GetColour()
    {
        return _colour;
    }
    public void SetColour(string colour)
    {
        _colour = colour;
    }

    public virtual double GetArea()
    {
        return -1;
    }
    
}