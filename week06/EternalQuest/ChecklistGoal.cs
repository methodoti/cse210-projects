using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0; 
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal(string name, string description, string points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _amountCompleted = amountCompleted; 
        _target = target;
        _bonus = bonus;
    }

    public override string RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted += 1;
            if (IsComplete())
            {
                string points = (int.Parse(_points) + _bonus).ToString();
                Console.WriteLine($"Congratulations! You have earned {points} points!");
                return points;
            }
            else
            {
                Console.WriteLine($"Congratulations! You have earned {_points} points!");
                return _points;
            }
        }
        else
        {
            Console.WriteLine($"Goal already completed! No points earned...");
            return "";
        }
    }
    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetDetailsString()
    {
        return $"{_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        // ChecklistGoal:Attend the temple,Attend and perform any ordinance,50,500,3,1
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}