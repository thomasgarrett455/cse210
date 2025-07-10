class Orders
{
    private Customer _customer;
    List<Product> _products;

    public Orders(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string TotalCost()
    {
        int cost = 0;
        foreach (var product in _products)
        {
            cost += product.TotalPrice();
        }
        return $"Total cost is: ${cost + _customer.ShippingPrice()}";
    }

    public string PackingLabel()
    {
        Console.WriteLine("Packing Label:");
        string label = "";
        foreach (var item in _products)
        {
            label += item.DisplayPackingInfo();
        }
        return label;
    }

    public string ShippingLabel()
    {
        Console.WriteLine("Shipping Label:");
        return $"{_customer.DisplayCustomerInfo()}";
    }
}