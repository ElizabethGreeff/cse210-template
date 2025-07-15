using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public int GetTop()
    {
        return _top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetTop(int topNumber)
    {
        _top = topNumber;
    }
    public void SetBottom(int bottomNumber)
    {
        _bottom = bottomNumber;
    }
    public string GetFractionString()
    {
        string words = $"{_top}/{_bottom}";
        return words;

    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}