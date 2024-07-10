using System;

class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine();
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(GetDuration());

        while (DateTime.Now < end)
        {
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountDown(4);
            Console.WriteLine("\n");
        }

        DisplayEndingMessage();
    }
}