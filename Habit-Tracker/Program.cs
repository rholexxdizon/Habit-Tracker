using Microsoft.Data.Sqlite;

namespace Habit_Tracker;

class Program
{
    static string connectionString = @"Data Source=habit-tracker.db";
    static void Main(string[] args)
    {
        Console.WriteLine("Habit Tracker");
        Console.WriteLine("Main Menu");
        Console.WriteLine("1 - Create a habit");
        Console.WriteLine("2 - Choose existing habit");
        Console.WriteLine("3 - Exit");

        string userInput = Console.ReadLine();

        switch(userInput)
        {
            case "1":
                CreateHabit();
                break;
            default:
                break;
        }

    }

    private static void CreateHabit()
    {
        Console.WriteLine("Name of the Habit:");
    }
}