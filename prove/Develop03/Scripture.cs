using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string [] wordsInText = text.Split(" ");
        for (int i = 0; i < wordsInText.Count(); i++)
        {
            Word newWord = new Word(wordsInText[i]);
            _words.Add(newWord);
        }
      
    }
    public void HideRandomWords(int numberToHide)
    {
        for (int i = 1; i <= numberToHide;)
        {
            Random random = new Random();
            int number = random.Next(_words.Count);
            if (_words[number].GetDisplayText() != "_____")
            {
                _words[number].Hide();
                i += 1;
            }
        } 
    }

    public string GetDisplayText()
    {
        string retVal = _reference.GetDisplayText() + ": ";

        foreach (var word in _words)
        {
            retVal += word.GetDisplayText() + " ";

        }
        return retVal;
    }
    public bool IsCompletelyHidden()
    {
        bool retVal = true;
        for (int i = -0; i < _words.Count(); i++)
        {
            retVal &= _words[i].IsHidden(); 
        }
        return  retVal;
    }

}