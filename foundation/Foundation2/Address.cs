using System;
using Microsoft.Win32.SafeHandles;

public class Address
{
    private string _street;
    private string _city;
    private string _stateProvidence;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _stateProvidence = state;
        _country = country;
    }


    public bool isUSA(){
        bool retValue = false;
        if (_country == "USA")
        {
            retValue = true;
        }
        return retValue;
    }
    public void ViewFullAddress()
    {
        Console.WriteLine($"{_street}");
        Console.WriteLine($"{_city}");
        Console.WriteLine($"{_stateProvidence}");
        Console.WriteLine($"{_country}");
    }
}
