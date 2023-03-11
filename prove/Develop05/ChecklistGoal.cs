public class ChecklistGoal : Goal
{
    public int _interval = 0;
    public int _targetCount;
    public int _bonusPoints;
    private string _strPoints;
    private string _strTargetCount;
    private string _strBonusPoints;
    
    public ChecklistGoal(string name, string description, int points, int totalPoints, int bonusPoints, string strPoints, int targetCount, string strTargetCount, string strBonusPoints, int interval, string strInterval) : base(name, description, points, totalPoints)
    {
        _targetCount = targetCount;
    }

    public override string GetName()
    {
        Console.WriteLine("What's a good name for this checklist goal? ");
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
    
    public int GetTargetCount()
    {
        Console.WriteLine("How many times does this goal need to be completed for a bonus? ");
        _strTargetCount = Console.ReadLine();
        _targetCount = Convert.ToInt32(_strTargetCount);
        return _targetCount;
    }

    public int GetBonusPoints()
    {
        Console.WriteLine("What is the bonus for completing it that many times? ");
        _strBonusPoints = Console.ReadLine();
        _bonusPoints = Convert.ToInt32(_strBonusPoints);
        return _bonusPoints;
    }
    

    public override void RecordEvent()
    {
        _interval++;
        Console.WriteLine(" ");
        Console.WriteLine($"Progress on checklist goal: {_name}, +{_points} points");

        if (_interval == _targetCount)
        {
            Console.WriteLine($"Completed checklist goal: {_name} +1000 bonus points!");
        }
    }

    public override string IsComplete()
    {
        return $"You've completed {_interval}/{_targetCount} times: {_name}";
    }
}