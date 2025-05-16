using System;

public class QuestionManager
{
    private PromptBank promptBank;
    private Random random;

    public QuestionManager()
    {
        promptBank = new PromptBank();
        random = new Random();
    }

    public string AskRandomprompt()
    {
        int index = random.Next(promptBank.Questions.Count);
        string prompt = promptBank.Questions[index];
        return prompt;
    }
}
