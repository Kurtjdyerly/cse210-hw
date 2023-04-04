public class OutdoorGathering : Event
{
    private string _weather;
    
    public OutdoorGathering(string name, string description, string weather) : base(name, description)
    {
        _weather = weather;
        _type = "Outdoor Gathering";
    }

    public override void FullDetails()
    {
        base.FullDetails();
        Console.WriteLine(_weather);
        Console.WriteLine();
    }
}
