public class Prompt
{
    public List<string> _prompts = new List<string>()
    {
        "What are all the things you're grateful for today?",
        "What steps did you take today towards a goal you're working on?",
        "How can you make tomorrow (even) better than today?",
        "Who made your day better today? How can you pay that feeling forward?",
        "What made today unique?",
        "What is something that made you laugh today?",
        "What is one thing you want or need to remember from today?"
    };
    public Prompt()
    {

    }
    public string GeneratePrompt()
    {
        Random randomGenerator = new Random();
        return _prompts[randomGenerator.Next(0, _prompts.Count())];   
    }

}