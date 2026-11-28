using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine();

        // Cretate 2 ORDERS w/ 2-3 PRODUCTS each

        //ORDER N°1
        Product product1 = new Product("Toy Race Car", "CPBWT", 5, 2);
        Product product2 = new Product("Wireless Headphones", "WLHPS", 15, 1);
        Product product3 = new Product("Redragon Mechanical Keyboard", "RDMKB", 100, 1);
        Address address1 = new Address("20 W 34th St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Ashley Sanchez", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Console.WriteLine("Order N°1:");
        Console.WriteLine($"Packing Label:\n{order1.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label: {order1.GetShippingLabel()}");
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");


        Console.WriteLine();
        Console.WriteLine("-------------------------------------------------");

        // ORDER N°2
        Product product4 = new Product("Baby Yoda Doll", "MTFBWY", 5, 2);
        Product product5 = new Product("Insulated Metal Bottle", "AIBOW", 10, 4);
        Address address2 = new Address("550 e/ 50 and 51", "Gonnet", "Buenos Aires", "ARG");
        Customer customer2 = new Customer("Iara Arias", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine("Order N°2:");
        Console.WriteLine($"Packing Label:\n{order2.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label: {order2.GetShippingLabel()}");
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}
