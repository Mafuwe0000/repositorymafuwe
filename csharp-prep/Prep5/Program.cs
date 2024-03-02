using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
    }
   
    Console.WriteLine($"Please enter your name : {PromptUserName}");
    Console.WriteLine($"Please enter your favorite Number : {userFavoriteNumber}");
    Console.WriteLine($"Brother {PromptUserName}, the square of your number is : {userFavoriteNumber}");
        
    static void DisplayWelcome ( )
    {
        Console.WriteLine("welcome to the Program!");
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
        int userFavoriteNumber=Console.Readline();
        
        return userFavoriteNumber
    }
    static int PromptUserNumber (int userNumber)
    {
        Console.WriteLine("Please enter any number :");
        int userNumber=Console.Readline();
        
        return userNumber
    }

    static void DisplayResult (strint userName, int squaredNumber)
    {
        int squared= squaredNumber ^1/2
        Console.WriteLine($"Hello Brother (Sister ) {promptUserName}, the square root of your number is {squared}")
    }
}