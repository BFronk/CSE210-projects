using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade?");
        string gradeValue = Console.ReadLine();
        int grade = int.Parse(gradeValue);
        string letter = "";
        if (grade >= 90)
        { 
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"You have a {letter} in the class");
    }
}