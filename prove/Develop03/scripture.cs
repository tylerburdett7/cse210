using System.Security.Cryptography;

public class Scripture {
    private Verse _verse;
    private string _reference;

    public Scripture() {
        _verse = null;
        _reference = null;
    }
    public Scripture(Verse verse, string reference) {
        _verse = verse;
        _reference = reference;        
    }
    
    public string GetScripture() {
        return _reference + _verse;
    }

    public void Display() {
        Console.Write(_reference + ": ");
        _verse.DisplayVerse();
    }
    
    public void HideWords() {
        _verse.HideWords();
    }

}