using System.Collections.Generic;

public class Prompts
{
    List<string> prompts = new List<string>()
    {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "Which places did you visited today?",
            "Where would you like to go tomorrow?",
            "What was the thing that you wanted to do, but you didn't?",
            "How were you a blessing to someone's life today?",
    };

    public string GetPrompt()
    {
        int rand = new Random().Next(0, prompts.Count);
        return prompts[rand];
    }



}