using System;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {
        Entry entry = new Entry();
        PromptGenerator prompts = new PromptGenerator();
        prompts._prompts.Add("How was your day?");
        prompts._prompts.Add("What was for breakfast?");
        prompts._prompts.Add("Who is your crush?");
        prompts._prompts.Add("Do you have a pet?");
        prompts._prompts.Add("What is your favorite moment?");
        entry._promptText = prompts.GetPrompt();
        Console.WriteLine(entry._promptText);
    }
}