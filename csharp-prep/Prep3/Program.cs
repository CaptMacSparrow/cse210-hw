using System;

class Program
{
    static void Main(string[] args)
    {
       // Console.Write("What is the magic number? ");
       // int MagicNumber = int.Parse(Console.ReadLine());
        
        Random randomGenerator = new Random();
        int MagicNumber = randomGenerator.Next(1, 101);
        
        int guess = -1;

        while (guess != MagicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > MagicNumber)
            {
                Console.Write("Lower. ");
            }
            else if (guess < MagicNumber)
            {
                Console.Write("Higher. ");
            }
            else
            {
                Console.Write("You guessed it!");
            }
        }
    }
}