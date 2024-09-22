using System;

class Program
{
    static void Main(string[] args)
    {
        // using System.Collections.Generic;
        Console.WriteLine("Welcome to the number statistic generator! Please enter a series of numbers and type 0 when you are finished");
        int userInput = -1;
        int listTotal = 0;
        List<int> numberList = new List<int>();
        int greatestNumber = 0;
        while (userInput != 0)

        {
            Console.Write("Add Number to list ");
            userInput = int.Parse(Console.ReadLine());
            numberList.Add(userInput);
        } 
        foreach (int number in numberList)
        {
            listTotal += number;
            if (number > greatestNumber)
            {
                userInput = greatestNumber;
            }

        }
        Console.WriteLine($"The total of the list is  {listTotal}");
        Console.WriteLine($"The average of the list is  {listTotal / (numberList.Count - 1)}");
    }
}