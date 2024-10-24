using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numberToGuess = random.Next(1, 101);
            int userGuess = 0;
            int numberOfGuesses = 0;
            int lowerBound = 1;
            int upperBound = 100;
            int bestScore = int.MaxValue;

            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("Choose a difficulty level: (1) Easy, (2) Medium, (3) Hard");
            string difficulty = Console.ReadLine();

            switch (difficulty)
            {
                case "1":
                    upperBound = 50;
                    Console.WriteLine("You've chosen Easy mode: Guess the number between 1 and 50.");
                    break;
                case "2":
                    upperBound = 100;
                    Console.WriteLine("You've chosen Medium mode: Guess the number between 1 and 100.");
                    break;
                case "3":
                    upperBound = 200;
                    Console.WriteLine("You've chosen Hard mode: Guess the number between 1 and 200.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Defaulting to medium mode.");
                    break;
            }
            
            while (true)
            {
                numberToGuess = random.Next(lowerBound, upperBound + 1);
                userGuess = 0;
                numberOfGuesses = 0;
                Console.WriteLine("I'm thinking of a number. Can you guess it?");

                while( userGuess != numberToGuess)
                {
                    Console.Write("Enter your guess: ");
                    string input = Console.ReadLine();

                    // Validate input
                    if (!int.TryParse(input, out userGuess))
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                        continue;
                    }

                    numberOfGuesses++;

                    if (userGuess < numberToGuess)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }   
                    else if (userGuess > numberToGuess)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! You guessed the number in {numberOfGuesses} tries.");
                        if (numberOfGuesses < bestScore)
                        {
                            bestScore = numberOfGuesses;
                            Console.WriteLine($"New best score! {bestScore} is the best score so far.");
                        }
                        else
                        {
                            Console.WriteLine($"Best score: {bestScore}");
                        }
                    }
                }

                Console.WriteLine("Would you like to play again? (y/n)");
                string playAgain = Console.ReadLine();
                if (playAgain.ToLower() != "y")
                {
                    Console.WriteLine("Thanks for playing!");
                    break;
                }
            }    
        }
    }
}