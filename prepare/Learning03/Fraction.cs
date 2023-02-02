using System;

public class Fractions
{
    private int _top;
    private int _bottom;

    public Fractions()
    {
        _top = 1;
        _bottom = 1;
        //Console.WriteLine("Hello");
        //string text = $"{_top}/{_bottom}";
        //Console.WriteLine($"{text}");
    }

    public Fractions(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
        //Console.WriteLine("Goodbye");
    }

    public Fractions(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
        //Console.WriteLine("Bye");
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }
    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}