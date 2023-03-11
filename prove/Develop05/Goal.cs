public abstract class Goal
{
    public string _name;
    public string _description;
    public int _points;
    public int _totalPoints { get; set; }

    public Goal(string name, string description, int points, int totalPoints)
    {
        _name = name;
        _description = description;
        _points = points;
        _totalPoints = totalPoints;
    }

    public abstract string GetName();

    public void SetName(string name)
    {
        _name = name;
    }

    public abstract string GetDescription();
    
    public void SetDescription(string description)
    {
        _description = description;
    }

    public abstract int GetPoints();
   
    public void SetPoints(int points)
    {
        _points = points;
    }
    
    public abstract void RecordEvent();

    public abstract string IsComplete();
}