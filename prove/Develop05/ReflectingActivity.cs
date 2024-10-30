using System;
using Microsoft.VisualBasic;

public class ReflectingActivity : Activity
{
    protected List<string> _questions;
    protected List<string> _prompts;
    
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
        Console.WriteLine("How long, in seconds, would you like for your session?");
        _duration = int.Parse(Console.ReadLine());
    }
    public void Run()
    {
        
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
        return _prompts[index];;  
    }
    public void DisplayRandomQuestion()
    {

    }
    public void DisplayRandomPrompt()
    {

    }
}
