using System;
public class Entry
{
    public string _date;
    public string _promptText;
    public string _textEntry;
    // public int _moodRating;
    
   
    public void Display()
    {     
        Console.WriteLine($"Date: {_date} Prompt: {_promptText}");  
        Console.WriteLine($"{_textEntry} ");//Mood Rating:{_moodRating}");
        Console.WriteLine("");
    }
    
}