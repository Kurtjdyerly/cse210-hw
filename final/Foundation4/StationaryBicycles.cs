public class StationaryBicycles : Activity
{
    private double _speed;
    
    public StationaryBicycles(string date, int lengthInMin, double speed) :base (date, lengthInMin)
    {
        _speed = speed;
        _type = "Stationary Bike";
    }

    public override double GetDistance()
    {
        return _speed * (_lengthInMin / 60);
    }
    public override double GetPace()
    {
        return _lengthInMin / GetDistance();
    }
    public override double GetSpeed()
    {
        return _speed;
    }
}