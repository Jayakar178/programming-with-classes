using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 (USA Customer)
        Address address1 = new Address("123 Elm St", "Provo", "UT", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "WM001", 25.99, 2));
        order1.AddProduct(new Product("Keyboard", "KB002", 49.99, 1));

        // Order 2 (International Customer)
        Address address2 = new Address("42 King St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Emily Wong", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Laptop Stand", "LS003", 39.99, 1));
        order2.AddProduct(new Product("Webcam", "WC004", 59.99, 2));
        order2.AddProduct(new Product("HDMI Cable", "HD005", 9.99, 3));

        // Display Order 1
        Console.WriteLine("\n--- Order 1 ---");
        Console.WriteLine("Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("\nShipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order1.GetTotalPrice():F2}");

        // Display Order 2
        Console.WriteLine("\n--- Order 2 ---");
        Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("\nShipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order2.GetTotalPrice():F2}");
    }
}
