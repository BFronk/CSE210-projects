using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer = new Customer();
    
    public Order(List<Product> products, Customer customer)
    {
        products = _products;
        customer = _customer;
    }
    public Customer GetCustomer()
    {
        return _customer;
    }
    public void AddProduct(Product p)
    {
        _products.Add(p);
    }

    public double OrderCost(List<Product> products, Customer customer) 
    {
        double total = 0;
        foreach (Product p in products)
        {
            
            double total_amount = p.GetPrice() * p.GetQuan();
            total += total_amount;
        }
        if (customer.isUSA())
        {
            total += 5;
        }
        else 
        {
            total += 35;
        }
        return total;
    }
    public List<Product> GetProducts()
    {
        return _products;
    }
    public void ProducePackingLabel()
    {
        foreach (Product p in _products)
        {
            Console.WriteLine($"{p.GetQuan()}");
        }
    }
    public void ProduceShippingLabel()
    {
        _customer.viewCostomer();
    }
}