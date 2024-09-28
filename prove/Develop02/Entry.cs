using System;
public class Entry
{
    public string _date;
    public string _promptText;
    public string _textEntry;

    public void Display()
    {
        Console.writeLine($"{_date} Prompt: {promptText} ");
    }
}