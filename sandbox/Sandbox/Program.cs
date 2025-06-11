using System;

class Program
{

    static void Main(string[] args)
    {

        int sleepTime = 250;
        int seconds = 30;
        int time = 10;

        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(seconds);

        string animationString = "(^_^)(-_-)";

        // int count = time;

        // while (DateTime.Now < endTime)
        // {
        //     Console.Write(count--);
        //     Thread.Sleep(1000);
        //     Console.Write("\b\b");
        // }

        while (DateTime.Now < endTime)
            {
                Console.Write(animationString[0..5]);
                Thread.Sleep(sleepTime);
                Console.Write("\b\b\b\b\b");
                // Console.Write("/");
                Console.Write(animationString[5..]);
                Console.Write("\b\b\b\b\b");
                // Console.Write("-");
                Thread.Sleep(sleepTime);
                // Console.Write("\b");
                // Console.Write("\\");
                // Thread.Sleep(sleepTime);
                // Console.Write("\b");
            }
    }
}
