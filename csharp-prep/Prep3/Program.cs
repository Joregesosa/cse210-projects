using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1, 10);
         
        int guess = 0;
        int attempts = 0;

        while (guess != magicNumber)
        {
            Console.Write("Enter your guess: ");
            guess = int.Parse(Console.ReadLine());
            attempts++;

            if (guess == magicNumber)
            {
                Console.WriteLine($"Congratulations! You guessed the magic number in {attempts} attempts.");
                
                Console.Write("Would you like to play again? (yes/no): ");
                string playAgain = Console.ReadLine();
                if (playAgain == "yes")
                {
                    magicNumber = randomNumber.Next(1, 10);
                    attempts = 0;
                }
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Your guess is too low. Try again.");
            }
            else
            {
                Console.WriteLine("Your guess is too high. Try again.");
            }
        }
    }
}