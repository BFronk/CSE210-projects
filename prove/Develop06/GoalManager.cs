using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
public class GoalManager
{
    private List<Goal> _goals= new List<Goal>();
    private int _score; 
    public GoalManager()
    {
        _score = 0;
    }
   public void Start()
   { 
        int userAction= 0;
        while (userAction != 6)
        {
            DisplayPlayerInfo();
            Console.WriteLine("");
            if (userAction == 0)
            {
                Console.WriteLine("welcome to the goals app!");
                Console.WriteLine("Select a choice from the menu");
            }
            else 
            {
                Console.WriteLine("Please choose another action:");
            }
            Console.WriteLine(" 1.Create new goal");
            Console.WriteLine(" 2.List Goals");
            Console.WriteLine(" 3.Save Goals");
            Console.WriteLine(" 4.Load Goals");
            Console.WriteLine(" 5.Record Event");
            Console.WriteLine(" 6.Quit");
            userAction = int.Parse(Console.ReadLine());
            if (userAction == 1)//create new goal
            {
                Console.WriteLine("");
                CreateGoal();
                Console.WriteLine("");
            }
            else if (userAction == 2)//list goals
            {
                Console.WriteLine("");
                //getgoalstring with checkbox
                ListGoalDetails();
                Console.WriteLine("");
            }
            else if (userAction == 3)//save goals
            {
                Console.WriteLine("");
                //get string representation ready to save goals to file
                Console.WriteLine("What is the fileneme?");
                SaveGoals(Console.ReadLine());
                Console.WriteLine("");
            }
            else if (userAction == 4)//load goals
            {
                Console.WriteLine("");
                Console.WriteLine("What is the fileneme?");
                LoadGoals(Console.ReadLine()); 
                Console.WriteLine("");
            }
            else if (userAction == 5)//record event
            {
                Console.WriteLine("");
                //mark a goal completed/award points for goal/increment a checklist goal
                RecordEvent();
                Console.WriteLine("");
            }           
        }        
   }
   public int GetScore()
   {
    return _score;
   }
   public void DisplayPlayerInfo()
   {
     Console.WriteLine($"you have {_score} points");
   }
   public void ListGoalNames()
   {
        int i = 1;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetName()}");
            i++;
        }
        
   }
   public void ListGoalDetails()
   { 
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i++;
        }
   }
   public void CreateGoal()
   {
                Console.WriteLine("Which type Of goal would you like to create? Types:");
                Console.WriteLine(" 1. Simple");
                Console.WriteLine(" 2. Eternal");
                Console.WriteLine(" 3. Checklist");
                int usertype = int.Parse(Console.ReadLine());
                Console.Write("Name of Goal: ");
                string name = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("Short description of goal: ");
                string description = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("Amount of points  awarded for completionn of goal? :");
                int points = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                if (usertype == 1)
                {
                    SimpleGoal goal = new SimpleGoal(name, description, points);
                    _goals.Add(goal);
                }
                else if (usertype == 2)
                {
                    EternalGoal goal = new EternalGoal(name, description, points);                    
                    _goals.Add(goal);
                }
                else if (usertype == 3)
                {
                    Console.Write("Amount of completions for bonus: ");
                    int target = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Console.Write("Amount of points awarded for full completion: ");
                    int bonus = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);                    
                    _goals.Add(goal);
                }
   }
   public void RecordEvent()
   {
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int goalCompleted = int.Parse(Console.ReadLine());
        _score += _goals[goalCompleted - 1].RecordEvent();
   }
   public void SaveGoals(string file)
   {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
   }
   public void LoadGoals(string file)
   {
        string[] lines = System.IO.File.ReadAllLines(file);
        for (int i = 0; i < lines.Count(); i++)
        {
            if (i == 0)
            {
                _score =int.Parse(lines[0]);
            }
            else
            {
                string [] goal = lines[i].Split(":");
                string goalType = goal[0];
                string [] parts = goal[1].Split("/");
                string name = parts[0];
                string description = parts[1];
                int points = int.Parse(parts[2]);
                if (goalType == "Simple Goal")
                {                  
                    bool complete = bool.Parse(parts[3]);
                    SimpleGoal simple = new SimpleGoal(name, description, points);
                    if (complete == true)
                    {
                        simple.IsComplete();
                    }
                    _goals.Add(simple);
                }
                else if (goalType == "Eternal Goal")
                {

                    _goals.Add(new EternalGoal(name, description, points));
                }
                else 
                {
                    int bonus = int.Parse(parts[3]);
                    int target = int.Parse(parts[4]);
                    int amountCompleted = int.Parse(parts[5]);
                    ChecklistGoal check = new ChecklistGoal(name, description, points, target, bonus);
                    check.SetAmountCompleted(amountCompleted);
                    _goals.Add(check);
                }
            }
        }
        Console.WriteLine($"");
        Console.WriteLine($"Done! Imported {_goals.Count()} goals.");
        Console.WriteLine($"");
    }
}