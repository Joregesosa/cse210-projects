using System;



class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description) : base(name, description)
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they are  related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(GetDuration());

        while (DateTime.Now < end)
        {
            DisplayQuestions();
            ShowSpinner(15);
        }
        
        Console.WriteLine('\n');
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        List<string> prompts = new List<string>();
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        string selected = _prompts[index];

        prompts.Add(_prompts[index]);
        _prompts.RemoveAt(index);

        if (_prompts.Count == 0)
        {
            _prompts = prompts;
            _prompts.Clear();
        }

        return selected;

    }

    public string GetRandomQuestion()
    {
        List<string> questions = new List<string>();
        Random random = new Random();
        int index = random.Next(0, _questions.Count);
        string selected = _questions[index];

        questions.Add(_questions[index]);
        _questions.RemoveAt(index);

        if (_questions.Count == 0)
        {
            _questions = questions;
            _questions.Clear();
        }

        return selected;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine(" --- " + GetRandomPrompt() + " ---\n");
    }

    public void DisplayQuestions()
    {
        Console.Write("\n> " + GetRandomQuestion() + " ");
    }
}