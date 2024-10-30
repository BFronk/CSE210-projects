using System;
using System.Runtime;
public class ChecklistGoal : Goal
{
    protected int _amountCompleted;
    protected int _target;
    protected int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus): base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }
    public void RecordEvent()
    {

    }
    public void IsComplete()
    {

    }
    public string GetStringrepresentation()
    {
        return "hi";
    }
    public string GetDetailsString()
    {
        return "hi";
    }
}