using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string number = Console.ReadLine();

        bool done = false;

        while (!done){
            Console.Write("\nWhat is your guess?");
            string guess = Console.ReadLine();
            Console.WriteLine();
            
            if (guess == number) {
                Console.WriteLine("You guessed it!");
                done = true;
            }
            else {
                Console.WriteLine("Please try again");
            }

        }
    }
}