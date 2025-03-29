using System.Numerics;

public class Product {
    private string _productName;
    private int _productId;
    private double _pricePerUnit;
    private int _quantity;

    public Product(string productName, int productId, double pricePerUnit, int quantity) {
        _productName = productName;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public double GetSubtotal() {
        double total = _quantity * _pricePerUnit;
        return total;
    }

    public int GetProductId() {
        return _productId;
    }

    public int GetQuantity() {
        return _quantity;
    }

    public string GetProductName() {
        return _productName;
    }

}