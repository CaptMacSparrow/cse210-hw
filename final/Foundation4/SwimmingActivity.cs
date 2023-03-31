public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(DateTime date, int length, int laps)
        :base(date, length)
        {
            _laps = laps;
        }

    public override double GetDistance()
    {
        double distance = _laps * 50 / 1000 * 0.62; 
        return distance;
    }

    public override double GetSpeed()
    {
        double speed = (GetDistance() / GetLength()) * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = GetLength() / GetDistance();
        return pace;
    }
}