public class Order {
    private List<Product> _products;
    private Customer _customer;
    public Order(List<Product> products, Customer customer) {
        _products = products;
        _customer = customer;
    }

    public double GetTotalCost() {
    double subtotal = 0;

    foreach(Product product in _products) {
        subtotal += product.GetSubtotal();
        }

    return _customer.CheckUsa() ? subtotal + 5 : subtotal + 35;
    }

    public double GetSubTotal() {
        double subtotal = 0;
        foreach(Product product in _products) {
        subtotal += product.GetSubtotal();
        }
        return subtotal;
    }


    public string GetPackingLabel() {
        string packingLabel = "";
        foreach(Product product in _products) {
            packingLabel += product.GetProductName() + ", ";
            packingLabel += product.GetProductId()+ "\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel() {
        return _customer.GetCustomerName() + ", " + _customer.GetAddress();
    }


}