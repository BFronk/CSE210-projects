using System;

public class BreathingActivity : Activity 
{
    public BreathingActivity()
    {   _name = "breathing";
        _description = "This activity will help you relax by focusing on your breathing in and out slowly. Clear your mind and focus on your breathing.";
        
    }
    public void Run()
    {
        base.DisplayStartingMessage();
        Console.WriteLine("How long, in seconds, would you like for your session?");
        int userDuration = int.Parse(Console.ReadLine());
        if (userDuration % 10 != 0)
        {
            Console.WriteLine("please choose a number divisible by 10");
        }
        else
        {
            _duration = userDuration;
        }
        base.ShowSpinner(3);
        Console.Clear();
        Console.WriteLine("Get Ready...");
        base.ShowSpinner(3);
        for (int i = _duration /10; i > 0; i--)
        {
            Console.WriteLine("");
            Console.Write("Breathe in...");
            base.ShowCountdownTimer(4);
            Console.WriteLine("");
            Console.Write("Breathe out...");
            base.ShowCountdownTimer(6);
        }
        Console.WriteLine("");
        base.DisplayEndingMessage();
        base.ShowSpinner(3);
        Console.Clear();
    }
}