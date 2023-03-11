public class EternalGoal : Goal
{
    private int _interval = 0;
    private string _strPoints;

    public EternalGoal(string name, string description, int points, int totalPoints, string strPoints, int interval, string strInterval) : base(name, description, points, totalPoints)
    {
        _interval = interval;
        _strPoints = strPoints;
    }

    public override string GetName()
    {
        Console.WriteLine("What's a good name for this eternal goal? ");
        _name = Console.ReadLine();
        return _name;
    }

    public override string GetDescription()
    {
        Console.WriteLine("How would you describe your goal? ");
        _description = Console.ReadLine();
        return _description;
    }

    public override int GetPoints()
    {
        Console.WriteLine("How many points is this goal worth? ");
        _strPoints = Console.ReadLine();
        _points = Convert.ToInt32(_strPoints);
        return _points;
    }
     public override void RecordEvent()
    {
        _interval++;
        Console.WriteLine($"Progress on eternal goal: {_name} +{_points} points");
        Console.WriteLine($"Points awarded: {_points}");
    }

    public override string IsComplete()
    {
        return $"{_interval}x  {_name}";
    }
}