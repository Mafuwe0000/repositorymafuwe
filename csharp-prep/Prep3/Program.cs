using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);
        
        while (guessNumber!=magicNumber)
        {
            Console.WriteLine("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());

                
            if (guessNumber>magicNumber)
            {
                Console.WriteLine("Higher");
                while (guessNumber>magicNumber)
            }
            else if (guessNumber<magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}