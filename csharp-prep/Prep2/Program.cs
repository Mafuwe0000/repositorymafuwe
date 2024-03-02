using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is your grade percentage, from 0 to 100? ");
        int gradePercent = Console.ReadLine();
        
        if (gradePercent>=90)
        {
         Console.WriteLine(" A");
        }
        else if (gradePercent<90 && gradePercent>=80 )
        {
         Console.WriteLine(" B");   
        }
        else if (gradePercent<80 && gradePercent>=70 )
        {
         Console.WriteLine(" C");   
        }
        else if (gradePercent<70 && gradePercent>=60 )
        {
         Console.WriteLine(" D");   
        }
        else  (gradePercent<60)
        {
         Console.WriteLine(" F");   
        }

    }
}