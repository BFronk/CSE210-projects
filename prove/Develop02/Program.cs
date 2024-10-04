using System;
using System.IO.Compression;
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        
        Journal currentJournal = new Journal();
        
        //new prompt class and prompt addition to randomizer
         
        string run = "yes";
        //loop for getting input  on waht the user would like to do. does not end until the user types 5 indicating they want to quit
        while (run == "yes")
        {        
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            string userAction = Console.ReadLine();
            if (userAction == "1")
            {
            Entry currentEntry = new Entry();
            currentJournal.AddEntry(currentEntry);
            }
            else if (userAction == "2")
            {
                foreach (Entry entry in currentJournal._entries)
                {
                    entry.Display();
                }
            }
            else if (userAction == "3")
            {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine();
                currentJournal.LoadFromFile(filename);
                
            }
            else if (userAction == "4")
            {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine();
                currentJournal.SaveToFile(filename);
            }
            else if (userAction == "5")
            {
                run = "no";
            }
            else 
            {
                Console.WriteLine("Please enter a valid response!");
            }
        }
    }
}
