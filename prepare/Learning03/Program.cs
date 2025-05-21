using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1);
        Fraction f2 = new Fraction(1, 5);
        Console.WriteLine(f2);
        Fraction fraction1 = new Fraction(3, 4); 
        double decimalValue = fraction1.GetDecimalValue(); 

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(decimalValue);


    }
}