public class Reception : Event {
    private string _rsvpEmail;

    public Reception(string rsvpEmail, string eventTitle, string description, string date, string time, Address address, string type ): base(eventTitle, description, date, time, address, type) {
        _rsvpEmail = rsvpEmail;
    }

    public void DisplayFullDetails() {
        Console.WriteLine(_type);
        Console.WriteLine($"RSVP: {_rsvpEmail}");
        DisplayStandardDetails();
    }
}