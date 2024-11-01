using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Running running = new Running(30, 4);
        activities.Add(running);
        Biking biking = new Biking(30, 10);
        activities.Add(biking);
        Swimming swimming = new Swimming(30, 50);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
        Console.WriteLine(activity.GetSummary());
        }
    }
}