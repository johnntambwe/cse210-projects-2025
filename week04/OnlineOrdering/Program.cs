using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine("__________________________________________________________________");

        //First Order 
        Address customer1Address = new Address("Greart East Road", "Silverest", "Lusaka", "Zambia");
        Customer customer1 = new Customer("John Ntambwe", customer1Address);
        Product customer1Product1 = new Product("Apple", 1234, 15, 4);
        Product customer1Product2 = new Product("Orange", 4321, 7, 2);
        Product customer1Product3 = new Product("Banana", 2468, 5, 6);
        Order order1 = new Order(customer1Product1, customer1);
        order1.SetProducts(customer1Product2);
        order1.SetProducts(customer1Product3);

        //Displaying the first order 
        order1.ShippingLabel();
        Console.WriteLine();
        order1.PackingLabel();
        Console.WriteLine("__________________________________________________________________");
        Console.WriteLine($"Total Price for the Order : ${order1.TotalPrice(customer1.IsCustomerInUsa())}");
        Console.WriteLine("__________________________________________________________________");

        //Second Order 
        Address customer2Address = new Address("Main Road", "Salt Lake City", "Utha", "USA");
        Customer customer2 = new Customer("Peter Johnson", customer2Address);
        Product customer2Product1 = new Product("Watch", 0023, 50, 2);
        Product customer2Product2 = new Product("Book", 01030, 23.5, 3);
        Product customer2Product3 = new Product("Ring", 2025, 100.98, 1);
        Order order2 = new Order(customer2Product1, customer2);
        order2.SetProducts(customer2Product2);
        order2.SetProducts(customer2Product3);

        //Displaying the first order 
        order2.ShippingLabel();
        Console.WriteLine();
        order2.PackingLabel();
        Console.WriteLine("__________________________________________________________________");
        Console.WriteLine($"Total Price for the Order : ${order2.TotalPrice(customer2.IsCustomerInUsa())}");
        Console.WriteLine("__________________________________________________________________");



        Console.ReadLine();
    }

    
}