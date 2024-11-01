using System;
public class Running : Activity
{
    private float _distance;
    public Running(int duration, float distance) : base(duration) 
    {
        _distance = distance;
    }

    public override double CalculateSpeed()
        {
            return (_distance / _duration) * 60;
        }

        public override  double CalculatePace()
        {
            return _duration / _distance;
        }
    public override string GetSummary()
    {
        string formattedDate = DateTime.Now.ToString("dd MMM yyyy");
        return $"{formattedDate} Distance: {_distance} miles Speed: {CalculateSpeed()}mph Pace:{CalculatePace()}min per mile";
    }
}