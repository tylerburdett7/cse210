using System.Net.Sockets;

public class Event {
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    protected string _type;

    public Event(string eventTitle, string description, string date, string time, Address address, string type) {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
    }

    public void DisplayStandardDetails() { //title description date time address
        Console.WriteLine($"{_eventTitle}\n{_description}\n{_date}\n{_time}");
        _address.DisplayAddress();
    }

    public void DisplayShortDescription() {
        Console.WriteLine($"{_type}, {_eventTitle}, {_date}");
    }

}  