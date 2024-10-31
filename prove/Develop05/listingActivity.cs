using System;
using System.ComponentModel;
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();
    
    public ListingActivity()
    {   _name = "listing";
        _description = "This activity will help you reflect on times in your life by having you list as many things as you can in a certain area";
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
        DateTime StartTime = DateTime.Now;
        DateTime EndTime = StartTime.AddSeconds(_duration);
        while (DateTime.Now < EndTime)
        {
            // if (DateTime.Now < EndTime)
            // {
            //     break;
            // }
            Console.Write("> ");
            userList.Add(Console.ReadLine());
            _count ++;

        }
        Console.WriteLine($"You've listed {_count} items!"); 
        return userList;
    }
    public void Run()
    {
        base.DisplayStartingMessage();
        Console.WriteLine("List as many responses you can to the followoing prompt:"); 
        string prompt = GetRandomPrompt();
        Console.WriteLine($"-- {prompt} --");
        GetListFromUser();
        base.DisplayEndingMessage();
    }
}