using System.Numerics;

public class Product
{
    string _name;
    int _productID;
    float _price;
    int _quantity;

    Product(string name, int productID, float price,int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    
    public float CalcTotalCost()
    {
        return _price * _quantity;
    }


}