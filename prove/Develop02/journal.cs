using System.Security.Cryptography.X509Certificates;

public class Journal {
    private List<string> Prompts = new List<string> {
            "What are three things you're grateful for today?",
            "Describe a moment that made you smile recently.",
            "What is a challenge you overcame, and what did you learn?",
            "Write about someone who inspires you and why.",
            "If you could give your past self one piece of advice, what would it be?",
            "What is a goal you're working towards, and what steps are you taking?",
            "Describe your perfect day from start to finish.",
            "Write about a time when you stepped out of your comfort zone.",
            "What emotions are you feeling today, and why?",
            "If you had unlimited time and resources, what would you do?"
        };
    public List<Entry> Entries {get; set;}
    public string dayRating;
    private FileManager fileManager;

    public Journal(string filePath) {
        Entries = new List<Entry>();
        fileManager = new FileManager(filePath);
        Entries = fileManager.LoadFromFile();
    }
    public string GetDayRating() {
        Console.WriteLine("Rate your day 1-5! 1 being not so good and 5 being a great day.");
        dayRating = Console.ReadLine();
        return dayRating;
    }
    public string GetRandomPrompt() {
        Random rnd = new Random();
        return Prompts[rnd.Next(Prompts.Count)];
    }

    public void AddEntry(string response, string dayRating) {
        string Prompt = GetRandomPrompt();
        Entry entry = new Entry(Prompt, response, dayRating);
        Entries.Add(entry);

        Console.WriteLine();
        Console.WriteLine("entry saved");
        Console.WriteLine("---------------------------\n");

        fileManager.SaveToFile(new List<Entry> {entry});

    }    
    public void DisplayAllEntries() {
        if (Entries.Count == 0) {
            Console.WriteLine("\nno entries yet.\n");
            return;
        }
        
        Console.WriteLine("\n---Journal Entries---");
        foreach(Entry entry in Entries) {
            entry.DisplayEntry();
        }
        Console.WriteLine();
        
    }
}