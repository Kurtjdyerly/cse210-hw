public abstract class Goal
{
    protected string _goalType;
    protected string _goalName;
    protected string _goalDescription;
    public int _pointValue;
  
    public Goal()
    {
    }
    public virtual void RecordEvent()
    {
        
    }
    public virtual void CreateNew()
    {
        Console.Write("What is the name of your Goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine();
        Console.Write("How many points is this goal worth? ");
        _pointValue = int.Parse(Console.ReadLine());
    }
    public virtual int getPoints()
    {
        return 0;
    }

    public virtual bool IsComplete()
    {
        return false;
    }
    public virtual void Display()
    {
        if (IsComplete())
        {
            Console.Write($"[X] {_goalName} ({_goalDescription})");
        }
        else
        {
            Console.Write($"[ ] {_goalName} ({_goalDescription})");
        }
    }
    public virtual void WriteGoal(StreamWriter WriteFile)
    {   
        WriteFile.Write($"{_goalType},{_goalName},{_goalDescription},{_pointValue}");
    }   
    public virtual void ReadLine(string[] parts)
    {
        _goalType = parts[0];
        _goalName = parts[1];
        _goalDescription = parts[2];
        _pointValue = int.Parse(parts[3]);

    }
}