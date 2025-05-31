using System;
// To exceed requirements i added functionality that can unhide words of the scripture
class Program
{
    static void Main(string[] args)
    {
        Reference myReference = new Reference("John", 3, 16);
        Scripture myScripture = new Scripture("For God so loved the world, the He gave His Only Begotten Son.");

        Console.WriteLine("Press quit to quit, press enter to hide 3 words, press u to unhide some words if you need help.");
        Console.WriteLine();

        myReference.DisplayReference();
        myScripture.DisplayScripture();

        string response = Console.ReadLine();

        while (response != "quit")
        {
            switch (response)
            {
                case "quit":
                    Environment.Exit(0);
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Press quit to quit, press enter to hide 3 words, press u to unhide some words if you need help.");
                    Console.WriteLine();
                    myReference.DisplayReference();
                    myScripture.Hide3();
                    myScripture.DisplayScripture();
                    if (myScripture.AreAllWordsHidden())
                    {
                        Environment.Exit(0);
                    }
                    break;

                case "u":
                    Console.Clear();
                    Console.WriteLine("Press quit to quit, press enter to hide 3 words, press u to unhide some words if you need help.");
                    Console.WriteLine();
                    myReference.DisplayReference();
                    myScripture.UnHide3();
                    myScripture.DisplayScripture();
                    break;
            }
            response = Console.ReadLine();
        }
    }    
}