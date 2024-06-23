using System;
using System.IO;

class Prompts
{
    public List<string> _prompts = new List<string>();

    public Prompts()
    {
        string fileName = "prompts.csv";

        if (!File.Exists(fileName))
        {
            Console.WriteLine("the prompts file does not exist");
            return;
        }

        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            _prompts.Add(line);
        }
    }

    public string RandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        return _prompts[index];

    }

}