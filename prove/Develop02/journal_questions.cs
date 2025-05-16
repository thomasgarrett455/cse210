using System.Collections.Generic;

public class PromptBank
{
    public List<string> Questions { get; private set; }

    public PromptBank()
    {
        Questions = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What am I grateful for today?",
            "How could the world be a lot better?",
            "What do you need to give yourself moe credit for?",
            "What is holding you back from being  more productive?",
            "What are the current goals you are working towards? Do they need to change?"
        };
    }
}