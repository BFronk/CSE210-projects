using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction(5, 7);
        Console.WriteLine($"{fraction1.getBottom()}");
        Console.WriteLine($"{fraction1.getFractionString()}");
        Console.WriteLine($"{fraction1.getDecimalValue()}");

        Console.WriteLine("What do you want the bottom of the fraction to be?");
        int userTop = int.Parse(Console.ReadLine());
        Fraction fraction2 = new Fraction(userTop);
        Console.WriteLine("What do you want the bottom of the fraction to be?");
        int userBottom = int.Parse(Console.ReadLine());
        fraction2.setBottom(userBottom);
        Console.WriteLine($"{fraction2.getBottom()}");
        Console.WriteLine($"{fraction2.getFractionString()}");
        Console.WriteLine($"{fraction2.getDecimalValue()}");
    }
}