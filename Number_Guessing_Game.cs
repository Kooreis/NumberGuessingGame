```CSharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101);
        int attempts = 0;
        bool isGuessed = false;

        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("Guess a number between 1 and 100:");

        while (!isGuessed)
        {
            string userInput = Console.ReadLine();
            int userGuess;

            if (int.TryParse(userInput, out userGuess))
            {
                attempts++;

                if (userGuess > secretNumber)
                {
                    Console.WriteLine("Too high! Try again:");
                }
                else if (userGuess < secretNumber)
                {
                    Console.WriteLine("Too low! Try again:");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You've guessed the number in {attempts} attempts.");
                    isGuessed = true;
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a number:");
            }
        }
    }
}
```