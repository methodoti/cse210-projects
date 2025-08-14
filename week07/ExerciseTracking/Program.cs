using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        DateTime runningDate = new DateTime(2025, 11, 3);
        Running running = new Running(runningDate, 30, 4.8);
        activities.Add(running);

        DateTime cyclingDate = new DateTime(2025, 8, 10);
        Cycling cycling = new Cycling(cyclingDate, 60, 20);
        activities.Add(cycling);

        DateTime swimmingDate = new DateTime(2025, 7, 5);
        Swimming swimming = new Swimming(swimmingDate, 45, 40);
        activities.Add(swimming);

        foreach (Activity activ in activities)
        {
            Console.WriteLine(activ.GetSummary());
        }
    }
}