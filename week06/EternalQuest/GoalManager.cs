using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    //Constructor
    public GoalManager()
    {

    }
    public GoalManager(Goal goal, int score)
    {
        _goals.Add(goal);
        _score = score;
    }
    //Getters and Setters
    public List<Goal> GetGoals()
    {
        return _goals;
    }
    public int Score()
    {
        return _score;
    }
    //Methods Related to the Menu
    public void Start()
    {
        string userInput = " ";
        while (userInput != "6")
        {
            DisplayPlayerInfo();
            Console.WriteLine(" ");
            Console.WriteLine("Menu Options:\n" +
                "1. Create New Goal\n" +
                "2. List Goals\n" +
                "3. Save Goals\n" +
                "4. Load Goals\n" +
                "5. Record Event\n" +
                "6. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = Console.ReadLine().ToLower();
            Console.WriteLine(" ");
            //Switch options
            switch (userInput)
            {
                case "1":
                    CreateGoal();
                    Console.WriteLine(" ");
                    break;
                case "2":
                    ListGoalDetails();
                    Console.WriteLine(" ");
                    break;
                case "3":
                    SaveGoals();
                    Console.WriteLine(" ");
                    break;
                case "4":
                    LoadGoals();
                    Console.WriteLine(" ");
                    break;
                case "5":
                    Console.WriteLine(" ");
                    RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("Thank you for your time, see you soon!");
                    //Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Oops! Choose between 1 and 4.");
                    break;

            }

        }

    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }
    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal);
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("Your Goals are: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        string userType = " ";
        Console.WriteLine("The Types of Goals are: \n" +
            "1. Simple Goal\n" +
            "2. Eternal Goal\n" +
            "3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        userType = Console.ReadLine().ToLower();

        //Asking the user to answer questions
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is the short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with the goal? ");
        string points = Console.ReadLine();
        int goalPoints = Convert.ToInt32(points);

        if (userType == "1")
        {
            _goals.Add(new SimpleGoal(goalName, goalDescription, goalPoints));
        }
        else if (userType == "2")
        {
            _goals.Add(new EternalGoal(goalName, goalDescription, goalPoints));
        }
        else if (userType == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int goalTarget = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int goalBonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(goalName, goalDescription, goalPoints, goalTarget, goalBonus));
        }
    }
    public void RecordEvent()
    {
        ListGoalNames();
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available to record");
            return;
        }
        Console.WriteLine("Which goal did you accomplish? ");
        string userInput = Console.ReadLine();
        int goalNumber = int.Parse(userInput);
        //if (goalNumber > 0 && goalNumber <= _goals.Count)
        //{ 
            
        //}
        //Need to be continued, I was stuck here.
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine($"{_score},");
                foreach (Goal goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
                Console.WriteLine("Goals saved successfully!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }

    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("No saved goals found. Start by creating new goal and save it to a file.");
        }
        try
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);
            lines = lines.Skip(1).ToArray();
            foreach (string line in lines)
            {
                string goal = line.Split("|")[0];
                switch (goal)
                {
                    case "SimpleGoal":
                        _goals.Add(SimpleGoal.newString(line));
                        break;
                    case "EternalGoal":
                        _goals.Add(EternalGoal.newString(line));
                        break;
                    case "ChecklistGoal":
                        _goals.Add(ChecklistGoal.newString(line));
                        break;
                }
            }
            Console.WriteLine("Goals loaded successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
            Console.WriteLine("Starting with an empty list.");
            _goals = new List<Goal>();
            _score = 0;
        }
    }
}















        
  
   

