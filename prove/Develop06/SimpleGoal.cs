using System;
using System.Collections;
public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool complete): base(name, description, points)
    {
        _isComplete = complete;
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
}