using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(7);
        // Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        int countTime = 2;
        while (DateTime.Now < endTime)
        {
            // Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(countTime);
            Console.WriteLine();

            Console.Write("Now breathe out...");
            ShowCountDown(countTime + (countTime / 2));
            Console.WriteLine();
            Console.WriteLine();

            countTime = 4;
        }
        DisplayEndingMessage();
    }
}