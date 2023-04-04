public class Reception : Event
{
    private List<string> _attendees = new List<string>();
    private string _email;
    
    public Reception(string name, string description, string email) : base(name, description)
    {
        _type = "Reception";
        _email = email;
    }

    public override void FullDetails()
    {
        base.FullDetails();
        Console.WriteLine(_email);
        Console.WriteLine();
    }

    public void RegisterPerson(string person)
    {
        _attendees.Add(person);
    }
}
