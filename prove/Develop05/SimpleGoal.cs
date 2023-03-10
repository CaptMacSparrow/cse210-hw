public class SimpleGoal : Goal
{
    //private int _bonusPoints;
    private string _strPoints;
    //private int _totalPoints;

    public SimpleGoal(string name, string description, int points, int totalPoints, string strPoints) : base(name, description, points, totalPoints)
    {
        _strPoints = strPoints;
    }

    

    public override string GetName()
    {
        Console.WriteLine("What's a good name for this goal? ");
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
        Console.WriteLine($"Goal completed: {_name}, {_description}");
        Console.WriteLine($"Points awarded: {_points}");
        //_totalPoints += _points;
        //return _points;
    }

    public override string IsComplete()
    {
        return $"[ ]  {_name}";
    }
}