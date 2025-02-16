using System;

class Program
{
    static void Main(string[] args)
    {

        bool done = false;
        var scriptureManager = new ScriptureManager();
        var scripture = scriptureManager.GetRandomScripture();

        Console.Clear();
        scripture.Display();
        Console.WriteLine("Press Enter to hide words or type 'quit' to exit:");

        
        while (!done)
        {
            string input = Console.ReadLine(); // Read user input directly

            if (input.Equals("quit", StringComparison.OrdinalIgnoreCase)) // If "quit" is typed
            {
                done = true; // Exit the loop
            }
            else if (string.IsNullOrEmpty(input)) // If "Enter" is pressed (empty input)
            {
                Console.Clear();
                scripture.HideWords();
                scripture.Display();
            }
            else
            {
                Console.WriteLine("Invalid input. Press Enter to hide words or type 'quit' to exit.");
            }
        }
    }
}