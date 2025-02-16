using System;

public class ScriptureManager {
    List<Scripture> _scriptures = [];

    public ScriptureManager() {
        _scriptures = ReadCSV();
    }

    private List<Scripture> ReadCSV() {
        string filePath = "scriptures.csv";

        string[] lines = File.ReadAllLines(filePath);

        List<Scripture> newScriptures = [];

        foreach(string line in lines) {
            string[] fields = line.Split('|');
            var scripture = new Scripture(new Verse(fields[1]), fields[0]);
        
            newScriptures.Add(scripture);
        }

        return newScriptures;
    }

    public Scripture GetRandomScripture() {
        Random random = new Random();
        int number = random.Next(0, 20);
        return _scriptures.ElementAt(number);
    }

}

