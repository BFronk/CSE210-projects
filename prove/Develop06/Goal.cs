using System;
using System.Reflection.Metadata.Ecma335;
public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;
    
    public string GetName() 
    {
        return _shortName;
    }
    protected Goal(string name, string description, int points)
    {
        _shortName  = name;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public string GetDetailsString()
    {
        return"hi";
    }
    public abstract string GetStringRepresentation();
}