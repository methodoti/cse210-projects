using System;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        string menuChoice;
        do
        {
            Console.WriteLine();
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            menuChoice = Console.ReadLine();

            if (menuChoice == "1") // 1. Create New Goal
            {
                CreateGoal();
            }
            else if (menuChoice == "2") //  2. List Goals
            {
                ListGoalDetails();
            }
            else if (menuChoice == "3") // 3. Save Goals
            {
                SaveGoals();
            }
            else if (menuChoice == "4") // 4. Load Goals
            {
                LoadGoals();
            }
            else if (menuChoice == "5") // 5. Record Event
            {
                RecordEvent();
            }
            else if (menuChoice == "6") // Quit
            {
            }
            else
            {
                Console.WriteLine("Wrong Choice!");
            }
            // Console.Clear();
        } while (menuChoice != "6");
    }
    public void DisplayPlayerInfo()
    {


        string currentLevelName = "Iron";
        string nextLevelName = "Bronze";
        int CurrentLevelPoints = 0;
        int nextLevelPoints = 500;
        
        int pointsNeeded;

        if (_score < 500)
        {
            currentLevelName = "Iron";
            CurrentLevelPoints = 0;
            nextLevelName = "Bronze";
            nextLevelPoints = 500;
        }
        else if (_score >= 500 && _score < 1350)
        {
            currentLevelName = "Bronze";
            CurrentLevelPoints = 500;
            nextLevelName = "Silver";
            nextLevelPoints = 1350;
        }
        else if (_score >= 1350 && _score < 2975)
        {
            currentLevelName = "Silver";
            CurrentLevelPoints = 1350;
            nextLevelName = "Gold";
            nextLevelPoints = 2975;
        }
        else if (_score >= 2975 && _score < 5251)
        {
            currentLevelName = "Gold";
            CurrentLevelPoints = 2975;
            nextLevelName = "Platinum";
            nextLevelPoints = 5251;
        }
        else if (_score >= 5251 && _score < 9427)
        {
            currentLevelName = "Platinum";
            CurrentLevelPoints = 5251;
            nextLevelName = "Diamond";
            nextLevelPoints = 9427;
        }
        else if (_score >= 9427 && _score < 16527)
        {
            currentLevelName = "Diamond";
            CurrentLevelPoints = 9427;
            nextLevelName = "Master";
            nextLevelPoints = 16527;
        }
        else if (_score >= 16527 && _score < 28597)
        {
            currentLevelName = "Master";
            CurrentLevelPoints = 16527;
            nextLevelName = "Grandmaster";
            nextLevelPoints = 28597;
        }
        else if (_score >= 28597 && _score < 49116)
        {
            currentLevelName = "Grandmaster";
            CurrentLevelPoints = 28597;
            nextLevelName = "Epic";
            nextLevelPoints = 49116;
        }
        else if (_score >= 49116 && _score < 83998)
        {
            currentLevelName = "Epic";
            CurrentLevelPoints = 49116;
            nextLevelName = "Legendary";
            nextLevelPoints = 83998;
        }
        else if (_score >= 83998)
        {
            currentLevelName = "Legendary";
            CurrentLevelPoints = 83998;
            nextLevelName = "Legendary";
            nextLevelPoints = 83998;
        }
        
        string progressBar;

        if (CurrentLevelPoints >= 83998)
        {
            pointsNeeded = 0;
            progressBar = new string('+', 20);
        }
        else
        {
            pointsNeeded = nextLevelPoints - _score;
            int totalPointsInLevel = nextLevelPoints - CurrentLevelPoints;
            int pointsEarnedInLevel = _score - CurrentLevelPoints;

            int progressBarWidth = 20;
            int plusCount = (pointsEarnedInLevel * progressBarWidth) / totalPointsInLevel;
            int minusCount = progressBarWidth - plusCount;

            progressBar = new string('+', plusCount) + new string('-', minusCount);
        }
        
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine($"Your level: {currentLevelName}");
        Console.WriteLine($"Points for the next level: {pointsNeeded}");
        if (CurrentLevelPoints >= 83998)
        {
            Console.WriteLine($"Epic [{progressBar}] {nextLevelName} (MAX!!)");
        }
        else
        {
            Console.WriteLine($"{currentLevelName} [{progressBar}] {nextLevelName}");
        }
    }
    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        // 1. "the name of your Simple Goal"
        int count = 0;
        foreach (Goal goals in _goals)
        {
            count += 1;

            string[] parts = goals.GetDetailsString().Split("(");
            Console.WriteLine($"{count}. {parts[0]}");
        }

    }
    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        // 1. [ ] "the name of your Simple Goal"("short description of simple goal")
        int count = 0;
        string isComplete = " ";
        foreach (Goal goals in _goals)
        {
            count += 1;
            if (goals.IsComplete())
            {
                isComplete = "X";
            }
            else
            {
                isComplete = " ";
            }

            Console.WriteLine($"{count}. [{isComplete}] {goals.GetDetailsString()}");
        }


    }
    public void CreateGoal()
    {
        string createGoalMenu;
        string createGoalName;
        string createGoalDescription;
        string createGoalPoints;
        int createGoalTarget;
        int createGoalBonus;

        Console.WriteLine("The type of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Witch type of goal would you like to create? ");
        createGoalMenu = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        createGoalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        createGoalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associates with this goal? ");
        createGoalPoints = Console.ReadLine();

        if (createGoalMenu == "1")
        {
            SimpleGoal simpleGoal = new SimpleGoal(createGoalName, createGoalDescription, createGoalPoints);
            _goals.Add(simpleGoal);
        }
        else if (createGoalMenu == "2")
        {
            EternalGoal eternalGoal = new EternalGoal(createGoalName, createGoalDescription, createGoalPoints);
            _goals.Add(eternalGoal);
        }
        else if (createGoalMenu == "3")
        {
            Console.Write("How many times does this goal need to be acocomplished for a bonus? ");
            createGoalTarget = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            createGoalBonus = int.Parse(Console.ReadLine());

            ChecklistGoal checkListGoal = new ChecklistGoal(createGoalName, createGoalDescription, createGoalPoints, createGoalTarget, createGoalBonus);
            _goals.Add(checkListGoal);
        }
        else
        {
            Console.WriteLine("Wrong Choice!");
        }
    }
    public void RecordEvent()
    {
        string recordItem;
        int convertedRecordItem;
        ListGoalNames();
        Console.Write("Witch goal did you accomplish? ");
        recordItem = Console.ReadLine();

        int count = 0;
        string recordPoints = "";

        if (int.TryParse(recordItem, out convertedRecordItem) && recordItem != "0")
        {
            if (convertedRecordItem > 0 && convertedRecordItem <= _goals.Count)
            {
                foreach (Goal goals in _goals)
                {
                    count += 1;

                    if (count == convertedRecordItem)
                    {
                        recordPoints = _goals[count - 1].RecordEvent();
                    }
                }
                if (recordPoints != "")
                {
                    _score += int.Parse(recordPoints);
                    Console.WriteLine($"You now have {_score} points.");
                }
            }
            else
            {
                Console.WriteLine("Wrong Choice!");
            }
        }
        else
        {
            Console.WriteLine("Wrong Choice!");
        }
    }
    public void SaveGoals()
    {
        string filename = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score.ToString());
            foreach (Goal goals in _goals)
            {
                outputFile.WriteLine(goals.GetStringRepresentation());
            }
            Console.WriteLine("finish creating");
        }

    }
    public void LoadGoals()
    {
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        _goals = new List<Goal>();

        string createGoalType;
        string createGoalName;
        string createGoalDescription;
        string createGoalPoints;
        bool createGoalCompleted;
        int createGoalBonus;
        int createGoalTarget;
        int createGoalAmount;

        string type = "";
        int score = 0;
        int count = 0;

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            if (count == 0)
            {
                score = int.Parse(parts[0]);
            }
            else
            {
                type = parts[0];
                string[] typeSplit = type.Split(":");
                createGoalType = typeSplit[0];
                createGoalName = typeSplit[1];
                createGoalDescription = parts[1];
                createGoalPoints = parts[2];

                if (createGoalType == "SimpleGoal")
                {
                    createGoalCompleted = bool.Parse(parts[3].ToLower());


                    if (createGoalCompleted == true)
                    {
                        SimpleGoal simpleGoal = new SimpleGoal(createGoalName, createGoalDescription, createGoalPoints, createGoalCompleted);
                        _goals.Add(simpleGoal);
                    }
                    else
                    {
                        SimpleGoal simpleGoal = new SimpleGoal(createGoalName, createGoalDescription, createGoalPoints);
                        _goals.Add(simpleGoal);
                    }
                }
                else if (createGoalType == "EternalGoal")
                {
                    EternalGoal eternalGoal = new EternalGoal(createGoalName, createGoalDescription, createGoalPoints);
                    _goals.Add(eternalGoal);
                }
                else if (createGoalType == "ChecklistGoal")
                {
                    createGoalBonus = int.Parse(parts[3]);
                    createGoalTarget = int.Parse(parts[4]);
                    createGoalAmount = int.Parse(parts[5]);
                    ChecklistGoal checkListGoal = new ChecklistGoal(createGoalName, createGoalDescription, createGoalPoints, createGoalTarget, createGoalBonus, createGoalAmount);
                    _goals.Add(checkListGoal);
                }
            }
            count++;
        }
        _score = score;
    }
}