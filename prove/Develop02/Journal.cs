using System;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    
    public void AddEntry(Entry newEntry)
    {   
        PromptGenerator prompt = new PromptGenerator();
        prompt._prompts.Add("How was your day?");
        prompt._prompts.Add("Take a task that you’ve been dreading and break it up into the smallest possible steps.");
        prompt._prompts.Add("Where did you see the Lord's hand today? ");
        prompt._prompts.Add("How much do your current goals reflect your desires vs someone else’s");
        prompt._prompts.Add("What was your favorite moment?");
        prompt._prompts.Add("Are you taking enough risks in your life? Would you like to change your relationship to risk? If so, how?");
        prompt._prompts.Add("How do the opinions of others affect you?");
        prompt._prompts.Add("How do you feel about asking for help?");
        prompt._prompts.Add("Imagine that you have arrived at a closed door. What does it look like and what’s on the other side?");
        prompt._prompts.Add("In what ways are you currently self-sabotaging or holding yourself back?");
        newEntry._promptText = prompt.GetPrompt();

        DateTime theCurrentTime = DateTime.Now;
        newEntry._date = theCurrentTime.ToShortDateString();

        Console.WriteLine($"Date: {newEntry._date} Prompt: {newEntry._promptText}");  
        Console.Write("> ");
        newEntry._textEntry = Console.ReadLine();
        _entries.Add(newEntry);        
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
            {
                entry.Display();
            }
    }
    public void LoadFromFile(string file)
    {
        int position = 0;
        
        string[] lines = System.IO.File.ReadAllLines(file);
        for (int i = -1; i < lines.Count()/3; i++) 
        { 
            Entry newEntry = new Entry();   
            //positiion works in groups of three and creates entries
            string [] parts = lines[position].Split(": ");
            string[] dateAndPrompt = parts[1].Split(" ");
            newEntry._date = dateAndPrompt[0];
            newEntry._promptText = parts[2];
            position += 1;   
            newEntry._textEntry = lines[position];
            position += 1;
            position += 1;
            _entries.Add(newEntry);
        }
    }
    
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file)) 
        { 
            for (int i = 0; i < _entries.Count; i++)
            {   
                Entry entry = _entries[i];
                outputFile.WriteLine($"Date: {entry._date} Prompt: {entry._promptText}");
                outputFile.WriteLine($"Response: {entry._textEntry}");
                
                if (i < _entries.Count - 1)
                {
                    outputFile.WriteLine("");
                }
                else 
                {
                    Console.Write("");
                }
            }
        }
    }
}
    
