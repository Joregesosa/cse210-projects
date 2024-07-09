using System;

class BreathingActivity : Activity
{
    BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner();
        ShowCountDown();
        DisplayEndingMessage();
    }
}