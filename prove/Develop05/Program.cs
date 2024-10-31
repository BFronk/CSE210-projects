using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfullness app! Please choose from the following options:");    
        Console.WriteLine("1.Breathing activity");
        Console.WriteLine("2.Reflecting activity");
        Console.WriteLine("3.Listing activity");
        Console.WriteLine("4.Quit");
        int userChoice = int.Parse(Console.ReadLine());
        while (userChoice != 4)
        {
            Console.Clear();    
            if (userChoice == 1)
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            if (userChoice == 2)
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.AddQuestion("Think of a time when you stood up for someone else.");
                reflecting.AddQuestion("Think of a time when you did something really difficult.");
                reflecting.AddQuestion("Think of a time when you helped someone in need.");
                reflecting.AddQuestion("Think of a time when you did something truly selfless.");

                reflecting.AddPrompt("Why was this experience meaningful to you?");
                reflecting.AddPrompt("Have you ever done anything like this before?");
                reflecting.AddPrompt("How did you get started?");
                reflecting.AddPrompt("How did you feel when it was complete?");
                reflecting.AddPrompt("What made this time different than other times when you were not as successful?");
                reflecting.AddPrompt("What is your favorite thing about this experience?");
                reflecting.AddPrompt("What could you learn from this experience that applies to other situations?");
                reflecting.AddPrompt("What did you learn about yourself through this experience?");
                reflecting.AddPrompt("How can you keep this experience in mind in the future?");
                reflecting.Run();

            }
            if (userChoice == 3)
            {
                ListingActivity listing = new ListingActivity();
                listing.AddPrompt("Who are people that you appreciate?");
                listing.AddPrompt("What are personal strengths of yours?");
                listing.AddPrompt("Who are people that you have helped this week?");
                listing.AddPrompt("When have you felt the Holy Ghost this month?");
                listing.AddPrompt("Who are some of your personal heroes?");
                listing.Run();
            }
            Console.WriteLine("Please choose another activity.");
            Console.WriteLine("1.Breathing activity");
            Console.WriteLine("2.Reflecting activity");
            Console.WriteLine("3.Listing activity");
            Console.WriteLine("4.Quit");
            userChoice = int.Parse(Console.ReadLine());       
        }   
    }
}