public class Running : Activity
{
    private double _distance;
    
    public Running(string date, int lengthInMin, double distance): base(date, lengthInMin)
    {
        _distance = distance;
        _type = "Running";
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetPace()
    {
        return _lengthInMin / _distance;
    }
    public override double GetSpeed()
    {
        return (_distance / _lengthInMin) * 60;
    }
}