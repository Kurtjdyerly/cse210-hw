public class SimpleGoal : Goal
{
    private bool _complete;
    public SimpleGoal()
    {

    }
    public override void RecordEvent()
    {
        _complete = true;
    }
    
    public override int getPoints()
    {
        if (IsComplete())
            return _pointValue;
        else
            return 0;
    }

    public override bool IsComplete()
    {
        if(_complete)
            return true;
        else
            return false;
    }
    public override void WriteGoal(StreamWriter WriteFile)
    {   
        base.WriteGoal(WriteFile);
        WriteFile.Write($",{_complete}\n");
    }  
    
    public override void CreateNew()
    {
        base.CreateNew();

        _goalType = "Simple goal";
    }
    public override void ReadLine(string[] parts)
    {
        base.ReadLine(parts);
        _complete = bool.Parse(parts[4]); 
    }
}