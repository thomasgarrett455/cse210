namespace JournalMenu
{
    using System;


    public class Menu
    {
        public void DisplayMenu()
        {
            int response = 0;
            while (response != 5)
            {
                // Console.Clear();
                Console.WriteLine("Welcome to the Journal Program!");
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Load entries from a file");
                Console.WriteLine("3. Save entries to a file");
                Console.WriteLine("4. Display all entries");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                response = int.Parse(Console.ReadLine());
            }
            switch (response)
            {
                case 1:
                    Console.WriteLine("You choose to write a new entry.");
                    // Call the method to write a new entry
                    break;
                case 2:
                    Console.WriteLine("Load entires.");
                    // Call the method to load entries from a file
                    break;
                case 3:
                    Console.WriteLine("Save entries.");
                    // Call the method to save entries to a file
                    break;
                case 4:
                    Console.WriteLine("Display all entries.");
                    // Call the method to display all entries
                    break;
                case 5:
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;     
            }
        }
    }

    // class Program
    // {
    //     static void Main1()
    //     {
    //         Menu menu = new Menu();
    //         menu.DisplayMenu();
    //     }
    // }
}