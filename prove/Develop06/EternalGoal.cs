using System;
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points): base(name, description, points){}

    public override int RecordEvent()
    {
        Console.WriteLine($"Congragulations! you've earned {_points} points!");
        return _points;
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"Eternal Goal:{_name}/{_description}/{_points}";
    }
}