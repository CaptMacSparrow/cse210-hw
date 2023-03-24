public class Video
{
    public string _name;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"Title: {_name}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine();
        Console.WriteLine("Comments: ");

        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }
    public int GetCommentsNumber()
    {
        return _comments.Count;
    }
}