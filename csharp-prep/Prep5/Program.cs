using System;
using System.Globalization;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PropmptUserName();

        int number = PromptUserNumber();
        
        int favNumSquared = SquareNumber(number);

        DisplayResult(name, favNumSquared);

    }
    static void DisplayWelcome() {
        Console.WriteLine("Welcome to the program!");
    }
    static string PropmptUserName() {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber() {
        Console.Write("What is your favorite number? ");
        string userInput = Console.ReadLine();
        int favNumber = int.Parse(userInput);
        return favNumber;
    }

    static int SquareNumber(int number) {
        int squaredNumber  = number * number;
        return squaredNumber;
    }

    static void DisplayResult(string name, int squaredNumber) {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}