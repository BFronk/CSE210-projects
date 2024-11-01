using System;
using System.Collections;
using System.Net.Http.Headers;
public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points): base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        int retVal = 0;
        if (IsComplete())
        {
            Console.WriteLine("You've already completed that Goal!");
        }
        else
        {
            _isComplete = true;
            Console.WriteLine($"Congragulations! you've earned {_points} points!");
            retVal += _points;
        }
        return retVal;
    }
    public override bool IsComplete()
    {
        bool retVal = false;
        if (_isComplete == true)
        {
            retVal = true;
        }
        return retVal;
    }
    public override string GetStringRepresentation()
    {
        return $"Simple Goal:{_name}/{_description}/{_points}/{_isComplete}";
    }
}