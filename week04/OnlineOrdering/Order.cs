using System;
using System.Collections.Generic;

public class Order
{
    //Attributes
    private List<Product> _products = new List<Product>();
    private List<Customer> _customers = new List<Customer>();
    //Constructors
    public Order()
    {
        _products = new List<Product>();
        _customers = new List<Customer>();
    }
    public Order(Product product, Customer customer)
    {
        _products.Add(product);
        _customers.Add(customer);
    }

    //Getters and Setters
    // public List<Product> products { get { return _products; } };
    public List<Product> GetProducts()
    { 
        return _products;
    }
    public void SetProducts(Product product)
    {
        _products.Add(product);
    }

    public List<Customer> GetCustomer()
    {
        return _customers;
    }
    public void SetCustomer(Customer customer)
    {
        _customers.Add(customer);
    }

    //Methods
    public double TotalPrice(bool customerLocation)
    {
        int shippingCost = 0;
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.ProductTotalCost();
        }
        if (customerLocation)
        {
            shippingCost = 5;
            return totalCost + shippingCost;

        }
        else
        {
            shippingCost = 35;
            return totalCost + shippingCost;
        }


    }

    public void PackingLabel()
    {
        for (int i = 0; i < _products.Count; i++)
        {
            Console.WriteLine($"Product Name: {_products[i].GetProductName()} - Product ID: {_products[i].GetProductId().ToString()}");
        }
    }

    public void ShippingLabel()
    {

        foreach (Customer customer in _customers)
        {
            Console.WriteLine($"Customer Name: {customer.GetCustomerName()}");
            Console.WriteLine($"Customer Address: {customer.GetCustomerAddress().DisplayAddress()}");
        }
    }










}