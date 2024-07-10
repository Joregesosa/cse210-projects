using System;

class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine("Welcome to the " + _name + " activity.\n");
        Console.WriteLine(_description + "\n");
        Console.Write("How long, in seconds, would you like to do this activity? ");
        _duration = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine("You have completed another " + _duration + " seconds of the " + _name + " activity.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(seconds);
        int counter = 0;
        while (DateTime.Now < end)
        {
            Console.Write(spinner[counter]);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            counter++;
            if (counter >= spinner.Count)
            {
                counter = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public int GetDuration()
    {
        return _duration;
    }
}