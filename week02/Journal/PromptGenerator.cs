public class PromptGenerator
{
    public List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>();

        _prompts.Add("What was the best part of my day?");
        _prompts.Add("What is something I'm grateful for today?");
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was a small, simple pleasure I enjoyed?");
        _prompts.Add("What challenge did I overcome today?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What did I learn today, about myself or the world?");
        _prompts.Add("Who did I help, or who helped me today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("What made me laugh or smile today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What is one thing I'm looking forward to tomorrow?");
        _prompts.Add("How did I take a step towards a long-term goal today?");
        _prompts.Add("What is a beautiful thing I saw today?");
        _prompts.Add("What is a piece of advice I would give myself based on today's experience?");
    }

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int _randomIndex = randomGenerator.Next(0, _prompts.Count);
        
        return _prompts[_randomIndex];
    }
}