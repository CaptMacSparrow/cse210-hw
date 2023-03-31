public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(DateTime date, int length, double speed)
        :base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double distance = (GetLength() * _speed) / 60;
        return distance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        double pace = 60 / _speed;
        return pace;
    }
}