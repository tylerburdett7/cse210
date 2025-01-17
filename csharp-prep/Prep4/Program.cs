using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, Type 0 when finished");

        int userNumber = 1;

        while (userNumber != 0) {
            Console.Write("Enter Number: ");
            string userInput = Console.ReadLine();

            userNumber = int.Parse(userInput);
            if (userNumber != 0) {
                numbers.Add(userNumber);
            }
        }

        int sum = GetSum(numbers);
        Console.WriteLine($"\nThe sum is {sum}");
        
        float average = ((float)sum) / numbers.Count();
        Console.WriteLine($"The average is {average}");

        int largestNumber = GetLargestNumber(numbers);
        Console.WriteLine($"Largest number is {largestNumber}");

    }

    static int GetSum(List<int> numbers) {
        int sum = 0;
        foreach(int number in numbers) {
            sum += number;
        }
        return sum;
    }

    static int GetLargestNumber(List<int> numbers) {
        int largeNum = 0;

        foreach(int number in numbers) {
            if (number > largeNum) {
                largeNum = number;
            }
        }
        return largeNum;
    }
}