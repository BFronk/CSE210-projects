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
        if (_country == "United States")
        {
            retValue = true;
        }
        return retValue;
    }
    public void fullAddress()
    {
        Console.WriteLine($"{_street}, {_city}, {_stateProvidence}, {_country}");
    }
}
