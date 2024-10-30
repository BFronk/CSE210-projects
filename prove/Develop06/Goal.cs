using System;
using System.Reflection.Metadata.Ecma335;
public class Goal
{
    private string _shortName;
    private string _description;
    private int _points;
    
    protected Goal(string name, string description, int points)
    {
        _shortName  = name;
        _description = description;
        _points = points;
    }
    public void RecordEvent()
    {

    }
    public bool IsComplete()
    {
        return true;
    }
    public string GetDetailsString()
    {
        return "Hello World!";
    }
    public string GetStringRepresentation()
    {
        return "Hello World!";
    }


}