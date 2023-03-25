public class EternalGoal : Goal
{
    private int _timesCompleted;
    public EternalGoal()
    {
    
    }
    
    
    public override void CreateNew()
    {
        base.CreateNew();
        _goalType = "Eternal goal";
    }
    public override void RecordEvent()
    {
    _timesCompleted += 1;
    }
    
    public override int getPoints()
    {
        return _pointValue * _timesCompleted;
    }

    public override bool IsComplete()
    {
        return false;
    }
    public override void WriteGoal(StreamWriter WriteFile)
    {   
        base.WriteGoal(WriteFile);
        WriteFile.Write($",{_timesCompleted}\n");
    } 
    public override void ReadLine(string[] parts)
    {
        base.ReadLine(parts);
        _timesCompleted = int.Parse(parts[4]); 
    }

 
}