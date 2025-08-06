using System;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalProduct = 0;
        double shipping = 0;
        foreach (Product product in _products)
        {
            
            totalProduct += product.GetTotalCost();
        }
        if (_customer.IsInUSA())
        {
            shipping = 5;
        }
        else
        {
            shipping = 35;
        }
        return totalProduct + shipping;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label = label + $"{product.GetName()} {product.GetProductId()} \n";
        }
        return label.Remove(label.Length - 1); // remove the last \n
    }

    public string GetShippingLabel()
    {
        string name = "";
        string address = "";
        string label = "";
        name = _customer.GetName();
        address = _customer.GetAddress().GetFullAddress();
        label = label + $"{name}\n{address}\n";
        return label.Remove(label.Length - 1);  // remove the last \n
    }
}