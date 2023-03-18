public class Activity
{
    private string _startingMessage;
    private string _endingMessage;
    protected int _time;
    
    public Activity(string start, string end)
    {
        _startingMessage = start;
        _endingMessage = end;

        Console.WriteLine(_startingMessage);
        Console.WriteLine();
        Console.WriteLine(_endingMessage);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        _time = int.Parse(Console.ReadLine());

        Console.WriteLine("Get Ready...");
        PauseAnimation(3);
        Console.WriteLine();
    }
    
    public void PauseAnimation(int time)
    {
        while (time > 0)
        {
            Console.Write("-");
            Thread.Sleep(500);
            time--;
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            time--;
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
            time--;
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            time--;
            Console.Write("\b \b");
        }
    }
    public void CountDown(int time)
    {
        while (time > 0)
        {
            Console.Write(time);
            Thread.Sleep(1000);
            time--;
            Console.Write("\b \b");
        }
        Console.WriteLine("\b \b");
    }



}