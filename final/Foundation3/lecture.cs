using System.Security.Cryptography.X509Certificates;
public class Lecture : Event {
    public string _speaker;
    public int _capacity;

    public Lecture(string speaker, int capacity, string eventTitle, string description, string date, string time, Address address, string type): base(eventTitle, description, date, time, address, type) {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void DisplayFullDetails() {
        Console.WriteLine(_type);
        Console.WriteLine($"Speaker:{_speaker} Capacity:{_capacity}");
        DisplayStandardDetails();
    }



}