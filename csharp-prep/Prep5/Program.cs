using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayMessage ()
        {
            Console.WriteLine("Welcome to the program! ");

        }
        static string PromtUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;

        }
        static int PromtUserNumber()
        {
            Console.Write("What is your favorite number? ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int SquareNumber(int number)
        {
            int squaredNumber = number * number;
            return squaredNumber;
        }
        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name}, the square of your number is {number}");
        }
        static void MainFunction()
        {
            DisplayMessage();
            string UserName = PromtUserName();
            int UserNumber = PromtUserNumber();
            int userNumberSquared = SquareNumber(UserNumber);
            DisplayResult(UserName, userNumberSquared);
        }
        MainFunction();
    }
}