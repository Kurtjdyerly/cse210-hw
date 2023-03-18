using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Menu Options: ");
                Console.WriteLine("\t1. Start breathing activity");
                Console.WriteLine("\t2. Start reflecting activity");
                Console.WriteLine("\t3. Start listing activity");
                Console.WriteLine("\t4. Quit");
                Console.Write("Select a choice from the menu: ");
                int menuSelect = int.Parse(Console.ReadLine());
                if (menuSelect == 1)
                {
                    BreathingActivity activity = new BreathingActivity();
                }
                
                else if (menuSelect == 2)
                {
                ReflectionActivity activity = new ReflectionActivity();  
                }
                else if (menuSelect == 3)
                {
                    ListingActivity activity = new ListingActivity();
                }
                else if (menuSelect == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("This is not a valid command");
                }  
                 
            }
            catch
            {
                Console.WriteLine("There was an error please try again");
            }        
    
        }
    }
}