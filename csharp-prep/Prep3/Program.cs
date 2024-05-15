using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());
        int guess = -1;
        while (magicNumber != guess)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber)
            {
                Console.WriteLine("Guess lower.");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Guess higher.");
            }
            else
            {
                Console.WriteLine("You guessed it right!");
            }
        }
    }
}