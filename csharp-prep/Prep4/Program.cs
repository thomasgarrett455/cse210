using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int input = -1;
        while (input != 0)
        {
            Console.Write("Enter a number: ");
            string userNumber = Console.ReadLine();
            input = int.Parse(userNumber);
            

            if (input != 0)
            {
                numbers.Add(input);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        int largest = 0;
        foreach(int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        int count = numbers.Count;
        int average = sum / count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The larget number is: {largest}");
        
    }
}