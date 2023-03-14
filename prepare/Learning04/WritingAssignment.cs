public class WritningAssignment : Assignment

{
    private string _title;

    public WritningAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
        
    }
    public string GetWritingInformation()
    {
        return _title + " by " + _studentName; 
    }
}   