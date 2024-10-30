using System;
using System.ComponentModel;
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();
    
    string p1 = "Think of a time when you stood up for someone else.";
    
    public ListingActivity()
    {   _name = "listing";
        _description = "This aactivity will help you reflect on times in your life by having you list as many things as you can in a certain area";
        Console.WriteLine("How long, in seconds, would you like for your session?");
        _duration = int.Parse(Console.ReadLine());
    }

    public void AddPrompt(string prompt)
    {
        _prompts.Add(prompt);
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int promptIndex = random.Next(_prompts.Count);
        return _prompts[promptIndex];
    }
    public List<string> GetListFromUser()
    {
        List<string> userList= new List<string>();
        return userList;
    }
    public void Run()
    {
        
    }
}