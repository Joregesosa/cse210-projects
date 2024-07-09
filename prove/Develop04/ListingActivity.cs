using System;

class ListingActivity : Activity
{   
    private int _count;
    private List<string> _prompts = new List<string>();

    ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner();
        ShowCountDown();
        DisplayEndingMessage();
    }

    public void GetRandomPromnt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        Console.WriteLine(_prompts[index]);
    }

    public void GetListFromUser()
    {
        Console.WriteLine("Enter the number of prompts: ");
        _count = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < _count; i++)
        {
            Console.WriteLine("Enter a prompt: ");
            _prompts.Add(Console.ReadLine());
        }
    }
}