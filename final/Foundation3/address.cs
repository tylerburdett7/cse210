public class Address {
    private string _street;

    private string _city;
    private string _state;
    public Address(string street, string city, string state) {
        _city = city;
        _state = state;
        _street = street;
    }

    public void DisplayAddress() {
        Console.WriteLine($"{_street}\n{_city}, {_state}");
    }
}