namespace JournalMenu
{
    using System;
    using System.IO.Enumeration;
    using Journalentry;

    public class Menu
    {
        private Journal journal = new Journal();
        public void DisplayMenu()
        {
            int response = 0;
            while (response != 5)
            {
                Console.WriteLine("Welcome to the Journal Program!");
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                response = int.Parse(Console.ReadLine());

                switch (response)
                {
                    case 1:
                        Console.WriteLine("You choose to write a new entry.");
                        QuestionManager questionManager = new QuestionManager();
                        string prompt = questionManager.AskRandomprompt();
                        Console.WriteLine($"Prompt: {prompt}");
                        Console.Write("> ");
                        string entry = Console.ReadLine();
                        JournalEntry journalentry = new JournalEntry(prompt, entry);
                        journal.AddEntry(journalentry);
                        journalentry.DisplayEntry();
                        break;
                    case 2:
                        Console.WriteLine("Display");
                        journal.DisplayAllEntries();
                        break;
                    case 3:
                        Console.WriteLine("Enter the filename to load from:");
                        Console.Write("> ");
                        string loadFile = Console.ReadLine();
                        journal.LoadFromFile(loadFile);
                        break;
                    case 4:
                        Console.WriteLine("Name your file:");
                        Console.WriteLine(">");
                        string file_name = Console.ReadLine();
                        journal.SaveToFile(file_name);

                        break;
                    case 5:
                        Console.WriteLine("Exiting the program. Goodbye!");
                        break;
                }
            }
        }
    }
}