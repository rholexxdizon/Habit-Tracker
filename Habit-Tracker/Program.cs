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
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            var createCmd = connection.CreateCommand();
            createCmd.CommandText =
                @$"CREATE TABLE IF NOT EXISTS habit_tracker (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Date TEXT,
                Quantity INTEGER
                )";
            createCmd.ExecuteNonQuery();

            Console.WriteLine("New table created");

            connection.Close();
            Console.ReadKey();
        }
    }
}