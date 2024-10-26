using System;

public class Order
{
    private List<Product> products = new List<Product>();
    private Customer _customer = new Customer();
    
    public int OrderCost() 
    {
        return 5 + 6;
    }

}