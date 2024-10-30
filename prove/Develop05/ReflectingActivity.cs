using System;

public class ReflectingActivity : Activity
{
   public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on Different times in your Life";
        Console.WriteLine("How long would you like to do the activity?");
        _duration = int.Parse(Console.ReadLine());
    }
    public void Run()
    {
        
    }
}
