using System;
using System.Collections.Generic;

public class Product
{
    //Attributes 
    private string _productName;
    private int _productId;
    private double _price;
    private int _quantity;

    //Constructors
    public Product()
    {
        _productName = " ";
        _productId = 0;
        _price = 0;
        _quantity = 0;
    }
    public Product(string name, int id, double price, int quantity)
    {
        _productName = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }

    //Getters and Setters
    public string GetProductName()
    {
        return _productName;
    }
    public void SetProductName(string name)
    {
        _productName = name;
    }

    public int GetProductId()
    {
        return _productId;
    }
    public void SetProductIdd(int id)
    {
        _productId = id;
    }

    public double GetPrice()
    {
        return _price;
    }
    public void SetPrice(double price)
    {
        _price = price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    //Methods
    public double ProductTotalCost()
    {
        return _price * _quantity;
    }


}