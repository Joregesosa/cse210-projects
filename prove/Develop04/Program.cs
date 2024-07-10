using System;

class Program
{
    static void Main(string[] args)
    {

        while (true)
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Start breathing activity");
            Console.WriteLine("    2. Start reflecting activity");
            Console.WriteLine("    3. Start listing activity");
            Console.WriteLine("    4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                Console.Clear();
                breathingActivity.Run();

            }
            else if (choice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                Console.Clear();
                reflectingActivity.Run();

            }
            else if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                Console.Clear();
                listingActivity.Run();

            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("\n\nInvalid choice, please try again.");
                Thread.Sleep(2000);
            }

        }



    }
}