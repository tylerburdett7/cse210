public class Customer {
    private string _name;
    private Address _address;

    public Customer(string name, Address address) {
        _name = name;
        _address = address;
    }

    public bool CheckUsa() {
        string country = _address.GetCountry();
        if(country == "USA" || country == "United States" || country == "United States of America") {
            return true;
        } 
        return false;
    }

    public string GetAddress() {
        return _address.GetFullAddress();
    }

    public string GetCustomerName() {
        return _name;
    }
}