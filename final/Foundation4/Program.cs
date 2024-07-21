using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Swimming swimming = new Swimming("2021-01-01", 30);
        activities.Add(swimming);
        Running running = new Running("2021-01-02", 30, 5);
        activities.Add(running);
        Cycling cycling = new Cycling("2021-01-03", 30, 10);
        activities.Add(cycling);

       Console.Clear();

        foreach (Activity activity in activities)
        {

            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();

        }

    }
}