public class FileManager {
    private string filePath;

    public FileManager(string filePath) {
        this.filePath = filePath;
    }

    public void SaveToFile(List<Entry> entries) {
        using (StreamWriter writer = new StreamWriter(filePath, true)) {
            Entry lastEntry = entries.Last();
            writer.WriteLine($"{lastEntry._date}|{lastEntry._dayRating}|{lastEntry._prompt}|{lastEntry._response}");
        }
        Console.WriteLine("Journal saved to file");

    }

    public List<Entry> LoadFromFile() {
        List<Entry> entries = new List<Entry>();

        if (File.Exists(filePath)) {
            string[] lines = File.ReadAllLines(filePath);
            foreach(string line in lines) {
                string[] parts = line.Split('|');

                if (parts.Length == 4) {
                    DateTime date = DateTime.Parse(parts[0]);
                    string dayRating = parts[1];
                    string prompt = parts[2];
                    string response = parts[3];

                    entries.Add(new Entry(prompt, response, date, dayRating));
                }
            }
           
        }
        else {
            Console.WriteLine("No Previous Entries Found");
        }

        return entries;

    }  


}