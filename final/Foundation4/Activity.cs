public abstract class Activity
{
    private DateTime _date;
    private int _length;

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public DateTime GetDate()
    {
        return _date;
    }
    public int GetLength()
    {
        return _length;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    
    public string GetSummmary()
    {
        string summary = $"{GetDate().ToString("dd MMM yyyy")} {GetType().Name} ({GetLength()} min) - Distance: {GetDistance():N1} miles, Speed: {GetSpeed():N1} mph, Pace: {GetPace():N1} min per mile";
        return summary;
    }
}