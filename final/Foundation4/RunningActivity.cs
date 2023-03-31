public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(DateTime date, int length, double distance)
        : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double speed = (GetDistance() / GetLength()) * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = (GetLength() / GetDistance());
        return pace;
    }
}