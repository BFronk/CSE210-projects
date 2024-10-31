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
        float num = _duration/10;
        System.Math.Ceiling(num);
        for (float i = num; i > 0; i--)
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
    }
}