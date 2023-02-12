using System;

public class Scripture
{
    private string _reference;
    private string _text;

    public Scripture(string reference, string text)
    {
        _reference = reference;
        _text = text;
    }

    public string GetReference()
    {
        return _reference;
    }

    public void SetReference(string reference)
    {
        _reference = reference;
    }

    public string GetText()
    {
        return _text;
    }

    public void SetText(string text)
    {
        _text = text;
    }

    public string ToString()
    {
        string scripture = $"{_reference}  {_text}";
        return scripture;
    }
}