using System;
using System.ComponentModel;
public class ListingActivity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public void SetPrompt(string prompt)
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
    private void Run()
    {
        
    }
}