using System;
using System.Diagnostics;
using System.Runtime.Serialization;
public class Activity()
{
    private string _name;
    private string _description;
    private int _duration;
    
    public void DisplayStartingMessage()
    {
        Console.WriteLine("This activity will help you relax by focusing on your breathing, which will be done in and out slowly.");
    }
    public void DisplayEndingMessage()
    {
    Console.WriteLine("Well done!!");
    Console.WriteLine("");
    Console.WriteLine("You have completed another 30 seconds of the breathing activity");
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

        DateTime StartTime = DateTime.Now;
        DateTime EndTime = StartTime.AddSeconds(10.5);
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
    }
}