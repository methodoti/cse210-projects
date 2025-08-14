using System;

public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override string GetActivityType()
    {
        return "Running";
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance / _lengthInMinutes) * 60;
    }
    public override double GetPace()
    {
        return _lengthInMinutes / _distance;
    }
}