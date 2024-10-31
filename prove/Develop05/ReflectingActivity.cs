using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

public class ReflectingActivity : Activity
{
    protected List<string> _questions = new List<string>();
    protected List<string> _prompts = new List<string>();
    
    public void AddQuestion(string question)
    {
        _questions.Add(question);
    }
    public void AddPrompt(string prompt)
    {
        _prompts.Add(prompt);
    }

   public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on different times in your Life";
    } 
    public void Run()
    {
        base.DisplayStartingMessage();
        DisplayRandomQuestion();
        DisplayRandomPrompt();
        base.DisplayEndingMessage();
    }
    public string GetRandomQuestion()
    {
        Random r = new Random();
        int index = r.Next(_questions.Count());
        return _questions[index];
    }
    public string GetRandomPrompt()
    {
        Random r = new Random();
        int index = r.Next(_prompts.Count());
        return _prompts[index];
          
    }
    public void DisplayRandomQuestion()
    {
        string question = GetRandomQuestion();
        Console.WriteLine($"Consider the following prompt: ");
        Console.WriteLine("");
        Console.WriteLine($" --- {question} ---");
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadKey();
        Console.WriteLine("");
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Console.Write("You may begin in:");
        ShowCountdownTimer(3);
        Console.Clear();
    }
    public void DisplayRandomPrompt()
    {
        string prompt1 = GetRandomPrompt();
        string prompt2 = GetRandomPrompt();
        while (prompt1 == prompt2)
        {
            prompt2 = GetRandomPrompt();
        }
        Console.Write($"> {prompt1}");
        ShowSpinner(_duration/2);
        Console.Write($"> {prompt2}");
        ShowSpinner(_duration/2);
    }
}
