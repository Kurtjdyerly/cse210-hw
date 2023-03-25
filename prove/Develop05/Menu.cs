public class Menu
{
    private List<Goal> _goals = new List<Goal>();
    private int _level = 1;
    
    public Menu()
    {
    }
    public void LvlUp()
    {
        _level += 1;
        Console.WriteLine($"Congrats you leveled up!!!\nYour current level is: Level {_level}");
    }
    public void Display()
    {
        try
        {
        Console.WriteLine($"\nYou have {getPoints()} points");
        Console.WriteLine($"Your current level is: Level {_level}\n");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("\t1. Create New Goal");
        Console.WriteLine("\t2. List Goals");
        Console.WriteLine("\t3. Save Goals");
        Console.WriteLine("\t4. Load Goals");
        Console.WriteLine("\t5. Record Event");
        Console.WriteLine("\t6. Quit");
        Console.Write("Select a choice from the menu: ");
        select(int.Parse(Console.ReadLine()));
        }
        catch
        {
            Console.WriteLine("There was an error please try again");
        }
    }
    public void select(int userSelection)
    {
        if (userSelection == 1)
        {
            CreateNew();
        }
        else if(userSelection == 2)
        {
            ListGoals();
        }
        else if(userSelection == 3)
        {
            SaveGoals();
        }
        else if(userSelection == 4)
        {
            LoadGoals();
        }
        else if(userSelection == 5)
        {
            RecordEvent();
        }
        else if(userSelection == 6)
        {
            Environment.Exit(0);
        }
        else 
        {
            Console.WriteLine("Sorry that is not a option. Please enter an integer from 1-6.\n");
        }

    }
    public void ListGoals()
    {
        int i = 1;
        Console.WriteLine("The Goals are: ");
        foreach (Goal goal in _goals)
        {
            Console.Write($"{i}. ");
            goal.Display();
            Console.WriteLine();
            i++;
        }
        Console.WriteLine();
    }
    
    public int getPoints()
    {
        int points = 0;
        foreach (Goal goal in _goals)
        {
            points += goal.getPoints();
        }
        if (points >= (_level * 500))
            {
                LvlUp();
            }
        return points;
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file?" );
        string filename = Console.ReadLine();

        
        using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Goal goal in _goals)
                {
                    goal.WriteGoal(outputFile);
                }
            }
        
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file?" );
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach(string line in lines)
        {
            string[] parts = line.Split(",");
            if (parts[0] == "Simple goal")
            {
                SimpleGoal newGoal = new SimpleGoal();
                newGoal.ReadLine(parts);
                _goals.Add(newGoal);
            }
            else if (parts[0] == "Eternal goal")
            {
                EternalGoal newGoal = new EternalGoal();
                newGoal.ReadLine(parts);
                _goals.Add(newGoal);
            }
            else if (parts[0] == "Checklist goal")
            {
                ChecklistGoal newGoal = new ChecklistGoal();
                newGoal.ReadLine(parts);
                _goals.Add(newGoal);
            }
            
        }

    }
    public void RecordEvent()
    {
        ListGoals();
        Console.Write("Which goal did you complete? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;
        _goals[goalIndex].RecordEvent();
        Console.WriteLine($"Congratulations! You have earned {_goals[goalIndex]._pointValue}\nYou now have {getPoints()} points");

    }
    public void CreateNew()
    {
        Console.WriteLine("\nThe types of Goals are: ");
        Console.WriteLine("\t1. Simple Goal");
        Console.WriteLine("\t2. Eternal Goal");
        Console.WriteLine("\t3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int typeGoal = int.Parse(Console.ReadLine());

        if (typeGoal == 1)
        {
            SimpleGoal newGoal = new SimpleGoal();
            newGoal.CreateNew();
            _goals.Add(newGoal);
        }
        else if (typeGoal == 2)
        {
            EternalGoal newGoal = new EternalGoal();
            newGoal.CreateNew();
            _goals.Add(newGoal);
        }
        else if (typeGoal == 3)
        {
            ChecklistGoal newGoal = new ChecklistGoal();
            newGoal.CreateNew();
            _goals.Add(newGoal);
        }
        else
        {
            Console.WriteLine("Error invalid input");
        }

    }
    
}