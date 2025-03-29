using System;

class Program
{
    static void Main(string[] args)
    {
        var banana = new Product("Banana", 109123, 1.99, 3);
        var hotWheels = new Product("Hot Wheels car", 120931, 399.99, 5);
        var iphone23 = new Product("iphone 23", 123919, 10000.23, 1);
        var poptarts = new Product("Poptarts", 124221, 12.05, 2);
        List<Product> products1 = new List<Product> {banana, hotWheels, poptarts};
        List<Product> products2 = new List<Product> {hotWheels, iphone23, banana};
        List<Product> products3 = new List<Product> {poptarts, hotWheels, iphone23, banana};
        

        var address1 = new Address("1674 E 1300 N", "Layton", "Utah", "USA");
        var customer1 = new Customer("Tyler Burdett", address1);
        var order1 = new Order(products1, customer1);

        var address2 = new Address("1234 E Main Street", "Calgary", "Alberta", "Canada");
        var customer2 = new Customer("Bill eh", address2);
        var order2 = new Order(products2, customer2);

        var order3 = new Order(products3, customer1);
        
        
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Subtotal: " + order1.GetSubTotal());
        Console.WriteLine("$" + order1.GetTotalCost());
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Subtotal: " + order2.GetSubTotal());
        Console.WriteLine("$" + order2.GetTotalCost());
        Console.WriteLine();

        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine("Subtotal: " + order3.GetSubTotal());
        Console.WriteLine("$" + order3.GetTotalCost());
        Console.WriteLine();



        
        

    }
}