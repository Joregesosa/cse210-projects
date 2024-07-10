using System;

class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description) : base(name, description)
    {

        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPromnt();

        Console.Write("You may begin in: ");
        ShowCountDown(3);
        Console.WriteLine();

        _count = GetListFromUser().Count;
        Console.WriteLine( "You listed " + _count + " items!\n");

        DisplayEndingMessage();
    }

    public void GetRandomPromnt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        Console.WriteLine(" --- " + _prompts[index] + " ---");
    }

    public List<string> GetListFromUser()
    {
        List<string> list = new List<string>();

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(GetDuration());

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            list.Add(Console.ReadLine());
        }

        return list;
    }
}