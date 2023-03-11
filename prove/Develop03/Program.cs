using System;
using System. Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        string userInput = "";

        while (userInput != "quit")
        {
            scripture.Display();
            for (int i= 0; i < 3; i++)
            {
                scripture.AddHiddenWord();
            }
            userInput = Console.ReadLine();
        }
    }
}