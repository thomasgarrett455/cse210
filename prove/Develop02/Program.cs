using System;
using JournalMenu;

class Program
{

    private static string ObtainFileName(string prompt)
    {
        Console.Write(prompt);
        string fileName = Console.ReadLine();
        return fileName;
    }
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.DisplayMenu();
    }
}