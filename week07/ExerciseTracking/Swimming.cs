using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override string GetActivityType()
    {
        return "Swimming";
    }
    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / _lengthInMinutes) * 60;
    }
    public override double GetPace()
    {
        return _lengthInMinutes / GetDistance();
    }
}