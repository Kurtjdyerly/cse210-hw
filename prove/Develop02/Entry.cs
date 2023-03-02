public class Entry
{
    public string _prompt = "";
    public string _date = "";
    public string _entry = "";

    public Entry()
    {
    }

    public void DisplayEntry()
    {
        Console.WriteLine(_date);
        Console.WriteLine(_prompt);
        Console.WriteLine(_entry);
        Console.WriteLine();
    }
}


