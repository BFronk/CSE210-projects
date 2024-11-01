using System;
using System.Net.Http.Headers;
using System.Runtime;
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public int GetTarget()
    {
        return _target;
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }
    public ChecklistGoal(string name, string description, int points, int target, int bonus): base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    public override int RecordEvent()
    {
        //method checks to see if task is already completed before adding 1 to the amount completed and possibly marking it completely complete
        int retVal = _points;
        if (IsComplete())
        {
            Console.WriteLine("You've already completed that Goal!");
            retVal = 0;
        }
        else 
        {
            _amountCompleted += 1;
            if (IsComplete())
            {
                retVal = _points + _bonus;
            }
        }
        Console.WriteLine($"Congragulations! you've earned {retVal} points!");
        return retVal;
    }
    public override bool IsComplete()
    {
        bool retVal = false;
        if (_target == _amountCompleted)
        {
            retVal = true;
        }
        return retVal;
    }
    public override string GetStringRepresentation()
    {
        return $"Checklist Goal:{_name}/{_description}/{_points}/{_bonus}/{_target}/{_amountCompleted}";

    }
    public override string GetDetailsString()
    {
        string checkbox = "[ ]";
        if (IsComplete())
        {
            checkbox = "[X]";
        }
        return  $"{checkbox} {_name} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }
}