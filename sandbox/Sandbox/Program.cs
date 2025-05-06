using System;

class Program
{
     static double AddNumbers(double a, double b)
      {
        return a + b;
      }

      static void DisplayGreeting()
      {
        Console.WriteLine("Hello Bob, how are you?");
      }

    static void Main(string[] args)
    {
     double total = AddNumbers(123.456, 654.321);
     Console.WriteLine(total);
     DisplayGreeting();
    }
}
