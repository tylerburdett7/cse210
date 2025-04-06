public class Outdoor : Event {
    private string _weather;

    public Outdoor(string weather, string eventTitle, string description, string date, string time, Address address, string type): base(eventTitle, description, date, time, address, type) {
        _weather = weather;
    }

    public void DisplayFullDetails() {
        Console.WriteLine(_type);
        Console.WriteLine(_weather);
        DisplayStandardDetails();
    }
}