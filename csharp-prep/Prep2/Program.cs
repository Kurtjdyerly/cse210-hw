using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        float gradePercentage = float.Parse(userInput);
        string letter;

        if (gradePercentage <= 90)
        {
            letter = "A";
        }
        
        else if (gradePercentage <= 80)
        {
            letter = "B";
        }
        
        else if (gradePercentage <= 70)
        {
            letter = "C";
        }
        
        else if (gradePercentage <= 60)
        {
            letter = "D";
        }

        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is  {letter}.");
        if (gradePercentage >= 70)
        {
            Console.WriteLine("congrats you passed the class!!");
        }
        else 
        {
            Console.WriteLine("you falied to pass the class.");
        }
    }
}