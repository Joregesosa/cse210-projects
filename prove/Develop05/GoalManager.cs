using System;
using System.Runtime.InteropServices;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        Console.Clear();

        string choice;
        do
        {
            DisplayPlayerInfo();
            Console.WriteLine(" Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write(" Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            else if (choice == "6")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

        } while (choice != "6");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($" \nYou have {_score} points.\n");
    }

    public void ListGoalNames()
    {
        Console.Clear();
        Console.WriteLine(" The goals are: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            Console.WriteLine($"  {i + 1}. {goal.GetShortName()}");
        }
        Console.WriteLine();
    }

    public void ListGoalDetails()
    {
        Console.Clear();
        Console.WriteLine(" The goals are: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            string check = goal.IsComplete() ? "[X] " : "[ ] ";
            Console.WriteLine($"  {i + 1}. {goal.GetDetailsString()}");
        }
        Console.WriteLine();
    }

    public void CreateGoal()
    {
        Console.WriteLine(" The types of goals are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write(" Which type of goal would you like to create? ");

        string goalType = Console.ReadLine();
        Console.Write(" What is the name of the goal? ");
        string shortName = Console.ReadLine();
        Console.Write(" What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write(" What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (goalType == "1")
        {
            SimpleGoal simple_goal = new SimpleGoal(shortName, description, points, false);
            _goals.Add(simple_goal);
        }
        else if (goalType == "2")
        {
            EternalGoal eternal_goal = new EternalGoal(shortName, description, points);
            _goals.Add(eternal_goal);
        }
        else if (goalType == "3")
        {
            Console.Write(" What is the target for this goal? ");
            string target = Console.ReadLine();
            Console.Write(" What is the bonus for this goal? ");
            string bonus = Console.ReadLine();
            ChecklistGoal checklist_goal = new ChecklistGoal(shortName, description, points, int.Parse(target), int.Parse(bonus));
            _goals.Add(checklist_goal);
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }

    public void RecordEvent()
    {
        Console.Clear();
        ListGoalNames();
        Console.Write(" Which goal did you accomplish? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal goal = _goals[goalIndex];
            goal.RecordEvent();

            // Console.WriteLine(goal);
            _score +=  goal.GetPoints();

            Console.WriteLine(" Congratulations! You have earned " + goal.GetPoints() + " points.");
            Console.WriteLine(" You now have " + _score + " points.");
        }
    }

    public void SaveGoals()
    {


        if (_goals.Count > 0)
        {
            Console.Write(" What is the file name for the goal file? ");
            string fileName = Console.ReadLine();
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                outputFile.WriteLine($"score:{_score}");
                foreach (var goal in _goals)
                {
                    outputFile.WriteLine($"{goal.GetStringRepresentation()}");
                }
            }
        }


    }

    public void LoadGoals()
    {
        Console.Write(" What is the file name for the goal file? ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            _goals.Clear();
            using (StreamReader inputFile = new StreamReader(fileName))
            {
                string line;
                while ((line = inputFile.ReadLine()) != null)
                {
                    if (line.StartsWith("score:"))
                    {
                        _score = int.Parse(line.Substring(6));
                    }
                    else
                    {
                        string[] parts = line.Split('~');
                        if (parts[0] == "1")
                        {
                            _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
                        }
                        else if (parts[0] == "2")
                        {
                            _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                        }
                        else if (parts[0] == "3")
                        {
                            ChecklistGoal checklist_goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                            checklist_goal.SetAmountCompleted(int.Parse(parts[6]));
                            _goals.Add(checklist_goal);

                        }
                    }
                }
            }
        }
    }


}