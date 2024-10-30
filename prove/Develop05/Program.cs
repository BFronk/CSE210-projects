using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfullness app! Please choose from the following options:");
        Console.WriteLine("");
        Console.WriteLine("1.Breathing activity");
        Console.WriteLine("2.Reflecting activity");
        Console.WriteLine("3.Listing activity");
        Console.WriteLine("4.Quit");
        int userChoice = int.Parse(Console.ReadLine());
        while (userChoice != 4)
        {
            if (userChoice == 1)
            {
                BreathingActivity breating = new BreathingActivity();
                breating.Run();
            }
            if (userChoice == 2)
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }
            if (userChoice == 3)
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
        }   
    }
}