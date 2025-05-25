using System;
using System.Collections.Generic;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _province;
    private string _country;

    //Constructors
    public Address()
    {
         _street = " ";
         _city = " ";
         _state = " ";
         _province = " ";
         _country = " ";
    }
    public Address(string street, string city, string state, string province, string country)
    {
        _street = street;
         _city = city;
        _state = state;
         _province = province;
        _country = country;
    }

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _province = " ";
        _country = country;
    }

    //Getters and Setters
    public string GetStreet()
    {
        return _street;
    }
    public void SetStreet(string street)
    { 
        _street = street;
    }

    public string GetCity()
    {
        return _city;
    }
    public void SetCity(string city)
    {
        _city = city;
    }

    public string GetState()
    {
        return _state;
    }
    public void SetState(string state)
    {
        _state = state;
    }

    public string GetProvince()
    {
        return _province;
    }
    public void SetProvince(string province)
    {
        _province = province;
    }

    public string GetCountry()
    {
        return _country;
    }
    public void SetCountry(string country)
    {
        _country = country;
    }

    // Methods
    public bool IsAddressInUsa()
    {
        if (_country.ToUpper()  == "USA" || _country == "US" || _country == "UNITED STATES OF AMERICA")
            return true;
        else
            return false;
    }
    public string DisplayAddress()
    {
        if(_province == " ")
            return $"{_street}, {_city}, {_state}, {_country}.";
        else
            return $"{_street}, {_city}, {_province}, {_country}.";

    }
}