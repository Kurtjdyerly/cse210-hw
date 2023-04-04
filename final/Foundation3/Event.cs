public class Event
{
    protected string _type;
    protected string _name;
    protected Address _address = new Address();
    protected string _description;
    protected DateTime _dateAndTime = new DateTime();

    public Event(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void SetDateTime(int year, int month, int day, int hour, int min, int sec)
    {
        _dateAndTime = new DateTime(year, month, day, hour, min, sec);
    }
    public void SetAddress(Address address)
    {
        _address = address;
    }
    public void StandardDetails()
    {
        Console.WriteLine(_name);
        Console.WriteLine(_description);
        Console.WriteLine(_dateAndTime);
        Console.WriteLine(_address);
        Console.WriteLine();
    }

    public virtual void FullDetails()
    {
        StandardDetails();
        Console.WriteLine(_type);
    }

    public void ShortDescription()
    {
        Console.WriteLine(_type);
        Console.WriteLine(_name);
        Console.WriteLine($"{_dateAndTime.ToString("MMMM")} {_dateAndTime.Day}, {_dateAndTime.Year} ");
        Console.WriteLine();
    
    }
    
}