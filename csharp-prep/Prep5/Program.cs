using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
    }
   
      
    static void DisplayWelcome ( )
    {
        Console.WriteLine("welcome to the Program!");
        string userName = PromptUserName();
        int userFavoriteNumber = PromptUserNumber();
        int squaredNumber = squaredNumber(PromptUserNumber)

        DisplayResult(userName, squaredNumber)
    }
    static string PromptUserName (string userName)
    {
        Console.WriteLine("Please enter your name:");
        string userName=Console.Readline();
        
        return userName;
    }
    static int PromptUserNumber (int userFavoriteNumber)
    {
        Console.WriteLine("Please enter your favorite number :");
        int userFavoriteNumber=int.Parse(Console.Readline());
        
        return userFavoriteNumber
    }
    static int SquareNumber (int number)
    {
        Console.WriteLine("Please enter any number :");
        int square=number * number;
        
        return square
    }

    static void DisplayResult (string userName, int squaredNumber)
    {
        Console.WriteLine($"Hello Brother (Sister ) {userName}, the square root of your number is {square}");
    }
}