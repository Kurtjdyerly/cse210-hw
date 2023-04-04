public abstract class Activity
{
    protected string _type;
    protected string _date;
    protected int _lengthInMin;

    public Activity(string date, int lengthInMin)
    {
        _date = date;
        _lengthInMin = lengthInMin;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual void GetSummary()
    {
        Console.WriteLine($"{_date} {_type} ({_lengthInMin} min)- Distance {GetDistance()}miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile");
    }

}