using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        bool play_again = true;
        Random randomGenerator = new Random();
        while (play_again)
        {
        int magic_number = randomGenerator.Next(1, 10);
        bool incorrect = true;

        int counter = 0;
        
        while (incorrect)
        {
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            int guess = int.Parse(userInput);
            counter++;
            
            if (guess == magic_number)
            {
                Console.WriteLine("'You guessed it in {counter} guesses.");
                incorrect = false;
                
                if (Console.ReadLine().ToLower() == "y") 
                {
                    play_again = true;
                }
                else
                {
                    play_again = false;
                }
            }
            else if (guess > magic_number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
        }
        }
    }
}