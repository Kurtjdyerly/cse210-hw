public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    
    public Lecture(string name, string description, string speaker, int capacity) : base(name, description)
    {
        _speaker = speaker;
        _capacity = capacity;
        _type = "Lecture";
    }

    public override void FullDetails()
    {
        base.FullDetails();
        Console.WriteLine(_speaker);
        Console.WriteLine($"Capacity: {_capacity}\n");
    }

}