using System;
using System.Collections.Generic;

public class Customer
{
    //Attributes 
    private string _customerName;
    private Address _address;

    //Constructors 
    public Customer()
    {
        _customerName = " ";
        _address = new Address();
    }
    public Customer(string name, Address address)
    {
        _customerName = name;
        _address = address;
    }

    //Getters and Setters
    public string GetCustomerName()
    { 
        return _customerName;
    }
    public void SetCustomerName(string name)
    {
        _customerName = name;
    }

    public Address GetCustomerAddress()
    {
        return _address;
    }
    public void SetCustomerAddress(Address address)
    {
        _address = address;
    }

    //Methods 
    public bool IsCustomerInUsa()
    {
       return _address.IsAddressInUsa();
    }



}