using System;
public class Swimming : Activity
{
    private int _laps;
    public Swimming(int duration, int laps) : base(duration)
    {
        _laps = laps;
    }
    
    public double CalculateDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }
    public override double CalculateSpeed()
    {
        return (CalculateDistance() / _duration) * 60;
    }
    public override double CalculatePace()
    {
        return _duration / CalculateDistance();
    }

    public override string GetSummary()
    {
        double roundedNum = Math.Round(CalculatePace(), 2);
        string formattedDate = DateTime.Now.ToString("dd MMM yyyy");
        return $"{formattedDate} Laps: {_laps} Distance:{CalculateDistance()} miles Speed: {CalculateSpeed()}mph Pace: {roundedNum} min per mile";
    }
}