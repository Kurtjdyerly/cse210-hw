public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
                    {
                        "Think of a time when you stood up for someone else.",
                        "Think of a time when you did something really difficult.",
                        "Think of a time when you helped someone in need.",
                        "Think of a time when you did something truly selfless."                    
                    };
    private List<string> _questions = new List<string>()
                    {
                        "Why was this experience meaningful to you?",
                        "Have you ever done anything like this before?",
                        "How did you get started?",
                        "How did you feel when it was complete?",
                        "What made this time different than other times when you were not as successful?",
                        "What is your favorite thing about this experience?",
                        "What could you learn from this experience that applies to other situations?",
                        "What did you learn about yourself through this experience?",
                        "How can you keep this experience in mind in the future?"            
                    };

    public ReflectionActivity(string start = "Welcome to the Reflection Activity", string end = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") : base("Welcome to the Reflection Activity"," This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        Perform();
    }
    
    public void Perform()
    {
        Random rnd1 = new Random();
        int index = rnd1.Next(_prompts.Count());
        string prompt = _prompts[index];
        Console.WriteLine("Consider the following prompt: \n");
        Console.WriteLine("---" + prompt +"---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience. ");
        Console.Write("You may begin in :");
        CountDown(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);
        while(DateTime.Now < endTime)
        {
            Console.Write(GenQuestion());
            PauseAnimation(10);
            Console.WriteLine();

        }
        Console.WriteLine("Well done!!");
        PauseAnimation(5);

    }
    public string GenQuestion()
    {
        int length = _questions.Count();
        string question;
        if (length <= 0)
        {
            question = "There are no more questions";
        }
        else
        {
            Random rnd = new Random();
            int index = rnd.Next(length);
            question = _questions[index];
            _questions.RemoveAt(index);
        }
        return "> " + question;
    }
}