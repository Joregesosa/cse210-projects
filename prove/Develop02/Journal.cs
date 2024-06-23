using System;
using System.IO;

class Journal
{
    public void Load(string fileName, List<Entry> entries)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File does not exist");
            return;
        }
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            Entry entry = new Entry();
            string[] parts = line.Split(';');
            entry._creationDate = parts[0];
            entry._title = parts[1];
            entry._content = parts[2];
            entries.Add(entry);
        }

    }

    public void Save(string fileName, List<Entry> entryList)
    {

        if (entryList.Count > 0)
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach (var entry in entryList)
                {
                    outputFile.WriteLine($"{entry._creationDate};{entry._title};{entry._content}");
                }
            }
        }

    }




}
