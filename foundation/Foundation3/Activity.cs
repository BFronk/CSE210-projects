using System;
using System.Diagnostics;
public abstract class Activity
{
    protected int _duration;

    public Activity(int duration)
    {
        // _distance = distance;
        _duration = duration;
    }
    // public virtual double CalculateSpeed()
    // {
    //     return (_distance / _duration) * 60;
    // }

    // public virtual double CalculatePace()
    // {
    //     return _duration / _distance;
    // }
    public abstract double CalculateSpeed();

    public abstract double CalculatePace();

    
    public abstract string GetSummary();
    // {
    //     string formattedDate = DateTime.Now.ToString("dd MMM yyyy");
    //     return $"{formattedDate} Distance: {_distance} miles Speed: {CalculateSpeed()}mph Pace:{CalculatePace()}min per mile";
    // }

}