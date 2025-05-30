using System;

class Program
{
    static void Main(string[] args)
    {
        Reference myReference = new Reference("John", 3, 16, 17);
        Scripture myScripture = new Scripture("For God so loved the world, the He gave His Only Begotten Son.");
        
        myReference.DisplayReference();
        myScripture.DisplayScripture();

    }
}