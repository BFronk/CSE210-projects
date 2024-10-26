using System;
using System.Runtime.CompilerServices;

public class Customer
{
    private Address _address;
    private string _name;
    private bool _isUSA;

    public Customer(){} 
    public Customer(Address address, string name, bool usa)
    {
        _address = address; 
        _name = name;
        _isUSA = usa;
    }
    public void viewCostomer()
    {
        Console.WriteLine($"");
    }

    public bool isUSA()
        {
        bool retVal = false;
        if (_address.isUSA() == true)
        {
            retVal = true;
        }
        return retVal;
    }
}