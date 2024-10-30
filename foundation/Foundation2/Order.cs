using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer = new Customer();
    
    public Order(List<Product> products, Customer customer)
    {
       _products = products;
       _customer = customer;
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
        Console.WriteLine("");
        Console.WriteLine("Items: ");
        foreach (Product p in _products)
        {
            string itemName = p.GetName();
            Console.WriteLine($"{itemName}({p.GetProductID()}) X {p.GetQuan()}");
        }
        Console.WriteLine("");
    }
    public void ProduceShippingLabel()
    {
        Console.WriteLine("");
        _customer.viewCostomer();
        Console.WriteLine("");
    }
}