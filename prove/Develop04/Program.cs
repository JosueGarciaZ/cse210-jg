using System;

// Creativity and Exceeding Requirements:
// 1. The menu keeps running after each activity, so the user can do more than one activity in a single session and only leaves by choosing "Quit".
// 2. Every completed activity is saved in a log file (activity_log.txt) with the date, activity name and duration. The menu has an option to view that log and see how many times activities have been performed.
// 3. The duration input is validated, so a wrong value does not crash the program.

public class Program
{
    public static void Main()
    {
        string choice = "";

        while (choice != "5")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. View activity log");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.RunBreath();
            }
            else if (choice == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.RunReflect();
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.RunList();
            }
            else if (choice == "4")
            {
                ShowLog();
            }
        }

        Console.WriteLine("Goodbye!");
    }

    public static void ShowLog()
    {
        Console.Clear();

        if (File.Exists("activity_log.txt"))
        {
            string[] lines = File.ReadAllLines("activity_log.txt");
            Console.WriteLine($"Activities completed so far: {lines.Length}");
            Console.WriteLine();
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("No activities have been completed yet.");
        }

        Console.WriteLine();
        Console.Write("Press enter to go back to the menu.");
        Console.ReadLine();
    }
}