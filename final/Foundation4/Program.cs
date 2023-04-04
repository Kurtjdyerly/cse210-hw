using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running run = new Running("03 Nov 2022", 30, 3);
        StationaryBicycles bike = new StationaryBicycles("04 March 2022", 60, 20);
        Swimming swim = new Swimming("26 Jan 2023", 120, 80);

        activities.Add(run);
        activities.Add(bike);
        activities.Add(swim);

        foreach (Activity activity in activities)
        {
            activity.GetSummary();
            Console.WriteLine();
        }
    }
}