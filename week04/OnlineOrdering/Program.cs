using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        // Order 1 (USA)
        Address address1 = new Address("123 Apple St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P1001", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "P1002", 25.00, 2));

        // Order 2 (Non-USA)
        Address address2 = new Address("45 Maple Road", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Lee", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headphones", "P2001", 50.00, 2));
        order2.AddProduct(new Product("Keyboard", "P2002", 75.00, 1));
        order2.AddProduct(new Product("Monitor", "P2003", 200.00, 1));

        orders.Add(order1);
        orders.Add(order2);

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.GetTotalCost():0.00}");
            Console.WriteLine(new string('-', 50));
        }
    }
}