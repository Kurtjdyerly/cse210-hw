using System;

class Program
{
    static void Main(string[] args)
    {
        WritningAssignment assignment1 = new WritningAssignment("Kurt Dyerly", "History","The Causes of World War II");
        MathAssignment assignment = new MathAssignment("Kurt Dyerly", "Math", "7.3", "8-19");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(assignment.GetHomeworkList());
        Console.WriteLine();
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(assignment1.GetWritingInformation());
    }


}