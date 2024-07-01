using System;
using System.IO;

class Data
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    private string _content;

    public Data()
    {
        String[] lines = File.ReadAllLines("data.csv");
        Random random = new Random();
        int index = random.Next(0, lines.Length);
        string line = lines[index];
        string[] parts = line.Split('~');

        _book = parts[0];
        _chapter = int.Parse(parts[1]);
        _verse = int.Parse(parts[2]);
        _endVerse = int.Parse(parts[3]);
        _content = parts[4];

    }

    public string getBook()
    {
        return _book;
    }

    public int getChapter()
    {
        return _chapter;
    }
    public int getVerse()
    {
        return _verse;
    }

    public int getEndVerse()
    {
        return _endVerse;
    }

    public string getContent()
    {
        return _content;
    }
}
