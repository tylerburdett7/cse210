using System;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "journalentries.txt";
        Journal journal = new Journal(filePath);

        Console.WriteLine("Welcome to the Journal Program");

        bool done = false;
        while (!done) {
            Console.WriteLine("Please Select an option");
            Console.WriteLine("1. New Entry\n2. Display Previous Entries\n3. Quit");

            string userInput = Console.ReadLine();
            int userChoice = int.Parse(userInput);

            if (userChoice == 1) { // new entry
                string dayRating = journal.GetDayRating();

                string prompt = journal.GetRandomPrompt();
                Console.WriteLine(prompt);

                string response = Console.ReadLine();

                journal.AddEntry(response, dayRating);
            }
            else if (userChoice == 2) { // display
                journal.DisplayAllEntries();
            }
            else if (userChoice == 3) { // quit
                done = true;
            }
            else {
                Console.WriteLine("Invalid Option");
            }
        }
    }
}