using System;

class Program
{
    static void Main(string[] args)
    {
        var fraction = new fraction(1, 2);
        Console.WriteLine(fraction.GetTop());
        Console.WriteLine(fraction.GetBottom());
        Console.WriteLine(fraction.GetFraction());
        Console.WriteLine(fraction.GetDecimalValue());
        
        fraction.setBottom(5);
        fraction.SetTop(2);
        Console.WriteLine(fraction.GetFraction());
    }
}