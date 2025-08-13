using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public SimpleGoal(string name, string description, string points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override string RecordEvent()
    {
        if (!IsComplete())
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            _isComplete = true;
            return _points;
        }
        else
        {
            Console.WriteLine($"Goal already completed! No points earned...");
            return "";
        }
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        // SimpleGoal: Give a talk, Sepak in Sacrament meeting when asked, 100,True
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }
}