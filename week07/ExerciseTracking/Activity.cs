using System;

public abstract class Activity
{
    protected DateTime _date;
    protected int _lengthInMinutes;

    public Activity(DateTime date, int length)
    {
        _date = date;
        _lengthInMinutes = length;
    }

    public string GetSummary()
    {
        string date = _date.ToString("dd MMM yyyy");
        return $"{date} {GetActivityType()}({_lengthInMinutes} min): Distance {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }

    public abstract string GetActivityType();
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
}

