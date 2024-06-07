using System;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();

        int number = 0;

        do
        {
            Console.Write("Enter a number (0 to stop): ");
            number = int.Parse(Console.ReadLine());

            numbers.Add(number);
        } while (number != 0);

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        double average = (double)sum / numbers.Count;

        int max = 0;
        foreach (int num in numbers)
        {
            if (num > max && num > 0)
            {
                max = num;
            }
        }
        numbers.Sort();
        string sortedNumbers = string.Join(", ", numbers);

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Maximum: {max}");
        Console.WriteLine($"Sorted numbers: {sortedNumbers}");

    }
}