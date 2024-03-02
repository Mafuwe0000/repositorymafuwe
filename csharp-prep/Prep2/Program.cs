using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is your grade percentage, from 0 to 100? ");
        int gradePercent = Console.ReadLine();
        
        string letter ="";

        if (gradePercent>=90)
        {
         letter="A";
        }
        else if (gradePercent<90 && gradePercent>=80 )
        {
         letter=" B";   
        }
        else if (gradePercent<80 && gradePercent>=70 )
        {
         letter="C";   
        }
        else if (gradePercent<70 && gradePercent>=60 )
        {
         letter =" D";   
        }
        else  (gradePercent<60)
        {
         letter="F";   
        }
        if gradePercent (>=70)
        {
            Console.WriteLine("You passed");
        }
        else
        {
            Console.WriteLine("Better luck next time!")
        }

    }
}