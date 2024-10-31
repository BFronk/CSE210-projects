using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
public class GoalManager
{
    private List<Goal> _goals= new List<Goal>();
    private int _score;
    GoalManager()
    {

    }
   public void Start()
   {
        int userAction= 0;
        while (userAction != 6)
        {
            DisplayPlayerInfo();
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1.Create new goal");
            Console.WriteLine(" 2.List Goals");
            Console.WriteLine(" 3.Save Goals");
            Console.WriteLine(" 4.Load Goals");
            Console.WriteLine(" 5.Record Event");
            Console.WriteLine(" 6.Quit");
            Console.WriteLine("Select a choice from the menu");
            userAction = int.Parse(Console.ReadLine());
        }
        
   }
   public void DisplayPlayerInfo()
   {
     Console.WriteLine($"you have {_score} points");
   }
   public void ListGoalNames()
   {
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{goal.GetName()}");
        }
   }
   public void ListGoalDetails()
   {
        foreach (Goal goal in _goals)
        {
            
        }
   }
   public void CreateGoal()
   {
    
   }
   public void RecordEvent()
   {
    
   }
   public void SaveGoals()
   {
    
   }
   public void LoadGoals(string file)
   {
        string[] lines = System.IO.File.ReadAllLines(file);
        for (int i = 0; i <+ lines.Count(); i++)
        {
            if (i == 1)
            {
                _score =int.Parse(lines[0]);
            }
            else
            {
                string [] goal = lines[i].Split(":");
                string goalType = goal[0];
                string [] parts = goal[1].Split(",");
                string name = parts[0];
                string description = parts[1];
                int points = int.Parse(parts[2]);
                if (goalType == "Simple Goal")
                {                  
                    bool complete = bool.Parse(parts[3]);
                    _goals.Add(new SimpleGoal(name, description, points, complete));
                }
                else if (goalType == "Eternal Goal")
                {

                    _goals.Add(new EternalGoal(name, description, points));
                }
                else 
                {
                    int bonus = int.Parse(parts[3]);
                    int target = int.Parse(parts[4]);
                    _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                }
            }
        }

   }
}