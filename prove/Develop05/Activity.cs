using System;
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    
    
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"welcome to the {_name} activity!");
        Console.WriteLine("");
        Console.WriteLine(_description);
        ShowSpinner(3);
        Console.WriteLine("How long, in seconds, would you like for your session?");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(3);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} activity!");
        ShowSpinner(3);
        Console.Clear();
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        Console.Write(" ");
        DateTime StartTime = DateTime.Now;
        DateTime EndTime = StartTime.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < EndTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i++;

            if (i >= animationString.Count)
            {
                i = 0 ;
            }
        }
        Console.WriteLine();
    }
    public void ShowCountdownTimer(int seconds)
    {
        Console.Write(" ");
        DateTime StartTime = DateTime.Now;
        DateTime EndTime = StartTime.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < EndTime)
        {
            Console.Write(seconds - i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
        }
        Console.WriteLine("");
    }
}