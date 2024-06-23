using System;

class Entry
{
    public string _title;
    public string _content;
    public string _creationDate;
    public void Display(List<Entry> _entries)
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine();
            Console.WriteLine($"Date: {entry._creationDate} - Prompt: {entry._title}");
            Console.WriteLine(entry._content);
            Console.WriteLine();
        }
    }


}