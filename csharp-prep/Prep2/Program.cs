using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Type your grade percentage:");
        int grade = int.Parse(Console.ReadLine());

        string letter = "";
        string sign = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade < 90 && grade >= 80)
        {
            letter = "B";
        }
        else if (grade < 80 && grade >= 70)
        {
            letter = "C";
        }
        else if (grade < 70 && grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (grade < 90 && grade >= 60)
        {
            if (grade % 10 >= 7)
            {
                sign += "+";
            }
            else if (grade % 10 < 3)
            {
                sign += "-";
            }
        }
        Console.WriteLine($"Your grade is, {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Sorry, better luck next time.");
        }

    }
}