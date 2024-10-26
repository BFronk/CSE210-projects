using System;

class Program
{
    static void Main(string[] args)
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
        Console.WriteLine("Done. ");
    }
    public void ShowCountdown(int seconds)
    {
        
    }
} 