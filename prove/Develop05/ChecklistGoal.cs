public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _target;
    private int _bonusPointValue;
    
    public ChecklistGoal()
    {

    }
    public override void RecordEvent()
    {
        _timesCompleted += 1;
    }
    public override void CreateNew()
    {
        base.CreateNew();
        {
        Console.Write("How many times does this need to be acomplished? ");
        _target = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPointValue = int.Parse(Console.ReadLine());
        _goalType = "Checklist goal";
        }
    }
    public override int getPoints()
    {
        if (IsComplete())
        {
            return _bonusPointValue + _pointValue * _target;
        }
        else
            return _timesCompleted * _pointValue;
    }

    public override bool IsComplete()
    {
        if (_timesCompleted >= _target)
            return true;
        else
            return false;
    }
    public override void Display()
    {
        base.Display();
        Console.Write($" -- Currently completed: {_timesCompleted}/{_target}");
    }
    public override void WriteGoal(StreamWriter WriteFile)
    {   
        base.WriteGoal(WriteFile);
        WriteFile.Write($",{_timesCompleted},{_target},{_bonusPointValue}\n");
    }  
    public override void ReadLine(string[] parts)
    {
        base.ReadLine(parts);
        _timesCompleted = int.Parse(parts[4]);
        _target = int.Parse(parts[5]);
        _bonusPointValue = int.Parse(parts[6]); 
    }
}