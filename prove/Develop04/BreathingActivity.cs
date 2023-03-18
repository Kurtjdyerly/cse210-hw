public class BreathingActivity : Activity
{
    private void Perform()
    {
        PauseAnimation(5);
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);
        while(DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            CountDown(4);
            Console.Write("Now Breathe out...");
            CountDown(4);
            Console.WriteLine();
        }
        Console.WriteLine("Well done!!");
        PauseAnimation(3);
    }
    public BreathingActivity(string start = "Welcome to the Breathing Activity. ", string end = "This activity will hlep you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.") : base("Welcome to the Breathing Activity. ", "This activity will hlep you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        Perform();
    }
}