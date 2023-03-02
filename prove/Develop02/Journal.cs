public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public string _fileName = "";

    public Journal()
    {
    }

    public void WriteEntry()
    {
        Entry newEntry = new Entry();
        newEntry._date = DateTime.Now.ToString("M-d-yyyy");
        Prompt newPrompt = new Prompt();
        newEntry._prompt = newPrompt.GeneratePrompt();
        Console.WriteLine(newEntry._prompt);
        newEntry._entry = Console.ReadLine();
        _entries.Add(newEntry);
    }
    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }
     public void SaveJournal()
    {
        Console.WriteLine("What is the file name? ");
        _fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {            
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._entry}");
            }
        }
    }
    public void LoadJournal()
    {
        Console.WriteLine("What is the file name? ");
        _fileName = Console.ReadLine();
            
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
            Entry load_entry = new Entry();

            string [] parts = line.Split("|");
            load_entry._date = parts[0];
            load_entry._prompt = parts[1];
            load_entry._entry = parts[2];

            _entries.Add(load_entry);
        }
    }
    public void RewriteEntry()
    {
        Console.WriteLine("Which entry would you liike to re-write");
        int i = 0;
        foreach (Entry entry in _entries)
        {
            Console.Write(i + 1);
            Console.WriteLine(".");
            Console.WriteLine(entry._date);
            Console.WriteLine(entry._prompt);
            Console.WriteLine(entry._entry);
            Console.WriteLine();
            i++;
        }
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine(_entries[choice - 1]._date);
        Console.WriteLine(_entries[choice - 1]._prompt);
        _entries[choice - 1]._entry = Console.ReadLine();

    }
    public int MainMenu()
    {
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Rewrite entry");
        Console.WriteLine("6. Quit");
        Console.WriteLine("What would you like to do? ");
        int choice = int.Parse(Console.ReadLine());
        return choice;
    }
}