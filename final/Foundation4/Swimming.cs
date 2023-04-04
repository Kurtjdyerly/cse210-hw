public class Swimming : Activity
{
    private int _laps;
    
    public Swimming(string date, int lengthInMin, int laps) : base(date, lengthInMin)
    {
        _laps = laps;
        _type = "Swimming";
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }
    public override double GetPace()
    {
        return _lengthInMin / GetDistance();
    }
    public override double GetSpeed()
    {
        return 60 / GetPace();
    }
}