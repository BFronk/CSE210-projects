using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is Your first name? ");
        string first = Console.ReadLine();
        Console.Write("what is Your last name? ");
        string last = Console.ReadLine();
        Console.WriteLine($"Your name is {last}, {first} {last}");
    }
}