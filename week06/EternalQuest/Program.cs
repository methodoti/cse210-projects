// EXCEEDING REQUIREMENTS:
// To exceed the project requirements, I have implemented a comprehensive "gamification" feature.
// This includes a 10-tier leveling system (from Iron to Legendary) based on the total points accumulated by the user.
// The system not only displays the user's current level but also shows a 20-character text-based progress bar,
// visually indicating how close the user is to reaching the next level. This entire logic is encapsulated
// within the DisplayPlayerInfo() method in the GoalManager class.
using System;

class Program
{
    static void Main(string[] args)
    {  
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}