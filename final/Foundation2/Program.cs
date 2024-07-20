using System;

class Program
{
    static void Main(string[] args)
    {

        Product product1 = new Product("Bread", 1, 10, 2);
        Product product2 = new Product("Milk", 2, 20, 3);
        Product product3 = new Product("Eggs", 3, 5, 12);
        Product product4 = new Product("Butter", 4, 15, 1);
        Product product5 = new Product("Cheese", 5, 25, 2);

        Address address1 = new Address("2822 Filbert Street", "Allentown", "PA", "USA");
        Address address2 = new Address("23 May street", "Santa Cruz", "SC", "BO");

        Customer customer1 = new Customer("Juan Sand", address1);
        Customer customer2 = new Customer("Maria Dolores", address2);

        Order order1 = new Order(new List<Product> { product1, product3, product5 }, customer1);
        Order order2 = new Order(new List<Product> { product2, product4, product1 }, customer2);

        Console.Clear();
        Console.WriteLine("Order 1:");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("-     -     -     -     -     -     -     -");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total: ${order2.GetTotalPrice()}");
        Console.WriteLine("----------------------------------------\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("-     -     -     -     -     -     -     -");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total: ${order2.GetTotalPrice()}");
        Console.WriteLine("----------------------------------------\n");

    }
}