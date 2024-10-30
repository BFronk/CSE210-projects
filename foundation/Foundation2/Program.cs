using System;
using System.ComponentModel;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products1 = new List<Product>();
        Product o1p1 = new Product("cheese", 563156, 4.99, 3);
        Product o1p2 = new Product("ham", 563156, 7.99, 3);
        Address add1 = new Address("527 12 street", "Vero Beach", "Florida", "USA");
        Customer cust1 = new Customer(add1, "Jeremy", false);
        Order order1 = new Order(products1, cust1);
        order1.AddProduct(o1p1);
        order1.AddProduct(o1p2);
        List<Product> products2 = new List<Product>();
        Product o2p1 = new Product("orange", 656646, 3.49, 7);
        Product o2p2 = new Product("apple", 648667, 2.99, 2);
        Address add2 = new Address("6418 97 cir", "Calgary", "Ontario", "Canada");
        Customer cust2 = new Customer(add2, "Thomas", false);
        Order order2 = new Order(products2, cust2);
        order2.AddProduct(o2p1);
        order2.AddProduct(o2p2);
        
        Console.WriteLine(order1.OrderCost(order1.GetProducts(),cust1));
        order1.ProducePackingLabel();
        order1.ProduceShippingLabel();
        Console.WriteLine(order2.OrderCost(order2.GetProducts(),cust2));
        order2.ProducePackingLabel();
        order2.ProduceShippingLabel();
    }
}