using System;
using System.Security.Cryptography.X509Certificates;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    public string GetPrompt()
    {
        Random random = new Random();
        int promptNumber = random.Next(_prompts.Count);
        string chosenPrompt = _prompts[promptNumber];
        return chosenPrompt;    
    }
}
