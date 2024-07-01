using System;
using System.IO;

class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public string getDisplayText()
    {
        string displayText = "";
        foreach (Word word in _words)
        {
            displayText += word.getDisplayText();
        }
        return _reference.getDisplayText() + " " + displayText;
    }

    public void hideRandomWord()
    {
        Random random = new Random();
        int counter = random.Next(2, 4);
        List<Word> availableWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.isHidden())
            {
                availableWords.Add(word);
            }
        }

        if (availableWords.Count > 3)
        {
            for (int i = 0; i < counter; i++)
            {
                int index = random.Next(0, availableWords.Count);
                availableWords[index].hide();
            }
        }
        else
        {
            foreach (Word word in availableWords)
            {
                word.hide();
            }
        }

    }

    public bool isCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.isHidden())
            {
                return false;
            }
        }
        return true;
    }

}