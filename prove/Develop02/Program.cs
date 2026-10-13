// 1. Each entry also saves a mood rating from 1 to 10, which is displayed, saved to the file, and loaded back.
// 2. Loading checks that the file exists, so a wrong filename does not crash the program or erase the current entries.
using System;
using System.Collections.Generic;
using System.IO;

class Menu
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the Journal Program!");
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine();
            Console.Write(@"Please select one of the following choices:
1. Write
2. Display
3. Load
4. Save
5. Quit
What would you like to do?
            ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                journal.Input();
            }
            else if (choice == "2")
            {
                journal.Display();
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                journal.Load(filename);
            }
            else if (choice == "4")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                journal.Save(filename);
            }
        }
    }
}