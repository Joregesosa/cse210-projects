using System;

class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
 
    public void DisplayStartingMessage()
    {
        Console.WriteLine("Starting activity: " + _name);
        Console.WriteLine("Description: " + _description);
        Console.WriteLine("Duration: " + _duration + " minutes");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Ending activity: " + _name);
    }

    public void ShowSpinner()
    {
        Console.WriteLine("Showing spinner for activity: " + _name);
    }

    public void ShowCountDown()
    {
        Console.WriteLine("Showing countdown for activity: " + _name);
    }
}