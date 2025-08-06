using System;

class Program
{
    static void Main(string[] args)
    {
        string costumerName;
        string street;
        string city;
        string state;
        string country;
        string productName;
        string productId;
        double price;
        int quantity;

        Console.WriteLine("Welcome to W04 Assignment: OnlineOrdering Program.");
        Console.WriteLine();

        // Costumer 1: International
        costumerName = "Juliana Silva";
        street = "Av. Paulista, 1578";
        city = "São Paulo";
        state = "SP";
        country = "Brazil";
        Address address = new Address(street, city, state, country);
        Customer customer1 = new Customer(costumerName, address);
        // Products
        productName = "Mecanic RGB Keyboard";
        productId = "KB-789";
        price = 95.50;
        quantity = 1;
        Product product1 = new Product(productName, productId, price, quantity);
        productName = "Wireless Gamer Mouse";
        productId = "WM-456";
        price = 45.00;
        quantity = 1;
        Product product2 = new Product(productName, productId, price, quantity);
        productName = "Headset 7.1 Surround";
        productId = "HS-123";
        price = 70.00;
        quantity = 1;
        Product product3 = new Product(productName, productId, price, quantity);
        // Order 1
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        // Costumer 2: USA Resident
        costumerName = "David Miller";
        street = "456 Oak Avenue";
        city = "Salt Lake City";
        state = "UT";
        country = "USA";
        Address address2 = new Address(street, city, state, country);
        Customer customer2 = new Customer(costumerName, address2);
        // Products
        productName = "Monitor Ultrawide 34\"";
        productId = "MON-UW-34";
        price = 450.00;
        quantity = 2;
        Product product4 = new Product(productName, productId, price, quantity);
        productName = "Webcam 4K";
        productId = "WC-4K-01";
        price = 120.00;
        quantity = 1;
        Product product5 = new Product(productName, productId, price, quantity);
        // Order 2        
        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Packing Label
        // order 1
        Console.WriteLine("= Packing Label:");
        Console.WriteLine($"{order1.GetPackingLabel()}");
        Console.WriteLine("= Shipping Label:");
        Console.WriteLine($"{order1.GetShippingLabel()}");
        Console.WriteLine($"= Order Total: ${order1.CalculateTotalCost()}");
        Console.WriteLine();
        // order 2
        Console.WriteLine("= Packing Label:");
        Console.WriteLine($"{order2.GetPackingLabel()}");
        Console.WriteLine("= Shipping Label:");
        Console.WriteLine($"{order2.GetShippingLabel()}");
        Console.WriteLine($"= Order Total: ${order2.CalculateTotalCost()}");
    }
}