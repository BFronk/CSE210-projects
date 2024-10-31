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
    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return "hi";
    }
    public string GetDetailsString()
    {
        return "hi";
    }
}