using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);
        int tries = 0;
        Boolean guess = false;
        while (guess == false)
        {
            Console.WriteLine("What is your guess for the magic number? ");
            string userGuess = Console.ReadLine();
            int input = int.Parse(userGuess);
            tries++;
            if (input == number)
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {tries} tries!");
                guess = true;
            }

            else if (input > number)
            {
                Console.WriteLine("You guessed too high!");
            }

            else
            {
                Console.WriteLine("You guess too low!");
            }

        }
    }
}