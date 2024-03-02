using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);
        
        Console.WriteLine("What is your guess? ");
        int guessNumber = Console.ReadLine();

               
        if (guessNumber>magicNumber)
        {
            Console.WriteLine("Higher");
            while (guessNumber>magicNumber)
            {
                Console.WriteLine("What is your guess? ");
                guessNumber=Console.ReadLine();
            }
        }
        else if (guessNumber<magicNumber)
        {
            Console.WriteLine("Lower");
            while (guessNumber<magicNumber)
            {
                Console.WriteLine("What is your guess? ");
                guessNumber=Console.ReadLine();
            }
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
    }
}