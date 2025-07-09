using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string userInput = Console.ReadLine();
        // int magicNumber = int.Parse(userInput);
        string playAgain = "yes";

        while (playAgain == "yes")
        {

            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int guess;
            int guesses = 0;

            do
            {
                Console.Write("What is yout guess? ");
                string userInput = Console.ReadLine();
                guess = int.Parse(userInput);
                guesses++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higer");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else {}
            } while (magicNumber != guess);
            Console.WriteLine($"You guessed it! (you took {guesses} guesses)");
            Console.Write("Do you want to play again? (yes/no)");
            playAgain = Console.ReadLine();
        }
    }
}