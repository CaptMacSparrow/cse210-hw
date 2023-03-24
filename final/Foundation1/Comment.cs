public class Comment
{
    public string _commentor;
    public string _text;

    public void Display()
    {
        Console.WriteLine($"{_commentor}: {_text}");
    }
}