public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
                    {
                        "Who are people that you appreciate?",
                        "What are personal strengths of yours?",
                        "Who are people that you have helped this week?",
                        "When have you felt the Holy Ghost this month?",
                        "Who are some of your personal heros?"                    
                    };
    private List<string> _answers = new List<string>();

    public ListingActivity(string start = "Welcome to the Reflection Activity", string end  = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") : base(start, end)
    {
        Perform();
    }
    
    public void Perform()
    {
        Random rnd1 = new Random();
        int index = rnd1.Next(_prompts.Count());
        string prompt = _prompts[index];
        Console.WriteLine("List as many resposes you can to the following prompt: \n");
        Console.WriteLine("\n---" + prompt +"---\n");
        Console.Write("You may begin in: ");
        CountDown(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);
        while(DateTime.Now < endTime)
        {
            Console.Write("> ");
            AddAnswer(Console.ReadLine());
        }
        Console.WriteLine($"You listed {_answers.Count()} items!\n");
        Console.WriteLine("Well done!!");
        PauseAnimation(5);

    }
    public void AddAnswer(string answer)
    {
        _answers.Add(answer);
    }
}