using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Enter a list of numbers, type 0 when finished.");
        string userInputString;
        int userInput = 1;
        List <int> numbers = new List<int>();

        while (userInput != 0)
        {
            Console.Write("Enter number: ");
            userInputString = Console.ReadLine();
            userInput = int.Parse(userInputString);
            numbers.Add(userInput);
        }
        int sum = numbers.Sum();
        float average = ((float)sum) / numbers.Count();
        int largestNum = 0;
        foreach (int number in numbers)
        {
            if (largestNum < number)
            {
                largestNum = number;
            }
        } 
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNum}");
    }
}