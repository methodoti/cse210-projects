using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you vcan in a certain aera.";

        _prompts = new List<string>();
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(7);

        Console.WriteLine("List as many responses you can to the followeing prompt:");
        GetRandomPrompt();
        Console.Write($"You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        _count = GetListFromUser().Count();
        Console.WriteLine($"You entered: {_count} inputs.");

        Console.WriteLine();
        DisplayEndingMessage();
    }
    public void GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int _randomIndex = randomGenerator.Next(0, _prompts.Count);

        Console.WriteLine($"--- {_prompts[_randomIndex]} ---") ;
    }
    public List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        List<string> userInput = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            // just a test
            userInput.Add(Console.ReadLine());
        }
        return userInput;
    }
}