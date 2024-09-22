using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int guess = 0;
        int number = randomGenerator.Next(1,11);
        while (number != guess) 
        {
            Console.Write("What is the magic number? ");
            guess = int.Parse(Console.ReadLine());
            if (number > guess)
            {
                Console.WriteLine("Higher! ");
            }   
            else if (number < guess)
            {
                Console.WriteLine("Lower! ");
            }
            else 
            {
                Console.WriteLine("You've Guessed it!");
            }
        }
    }
}