using System;
using System.Reflection.Metadata.Ecma335;
public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    
    public string GetName() 
    {
        return _name;

    }
    protected Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        string checkbox = "[ ]";
        if (IsComplete())
        {
            checkbox = "[X]";
        }
        return  $"{checkbox} {_name} ({_description})";
    }
    public abstract string GetStringRepresentation();
}