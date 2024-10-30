using System;
using System.ComponentModel;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products1 = new List<Product>();
        Product p1 = new Product("cheese", 563156, 4.99, 3);
        Product p2 = new Product("ham", 563156, 7.99, 3);
        // Order order1 = new Order(products1, new Customer(new Address("527 12 street", "Vero Beach", "Florida", "USA"), "Jermy", false));
        Address add1 = new Address("527 12 street", "Vero Beach", "Florida", "USA");
        Customer cust1 =  new Customer(add1, "Jermy", false);
        Order order1 = new Order(products1, cust1);
        order1.AddProduct(p1);
        order1.AddProduct(p2);
        // Customer order1cust = order1.GetCustomer();
        // Address order1add = order1cust.GetAddress();
        // p1.CalcTotalCost();
        double order1cost = order1.OrderCost(order1.GetProducts(),cust1);
        Console.WriteLine(order1cost);
    }
}