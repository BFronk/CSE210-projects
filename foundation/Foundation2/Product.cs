using System.Dynamic;
using System.Numerics;
public class Product
{
    private string _name;
    private int _productID;
    private double _price;
    private int _quantity;

    public Product(string name, int productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    
    public double GetPrice()
    {
        return _price;
    }
    public float GetQuan()
    {
        return _quantity;
    }
    public double CalcTotalCost()
    {
        return _price * _quantity;
    }
}