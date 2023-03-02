using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the journal Program!");
        bool run = true;
        Journal journal1 = new Journal();
        while (run)
        {
            int choice = journal1.MainMenu();
            switch(choice)
            {
                case 1:
                    journal1.WriteEntry();
                    break;
                case 2:
                    journal1.DisplayJournal();
                    break;
                case 3:
                    journal1.LoadJournal();
                    break;
                case 4:
                    journal1.SaveJournal();
                    break;
                case 5:
                    journal1.RewriteEntry();
                    break;
                case 6:
                    run = false;
                    break;
            }
        }
    }
}