class Order
{

    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double GetTotalPrice()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }
        if (_customer.IsInUSA())
        {
            return totalCost + 5;
        }
        else
        {
            return totalCost + 35;
        }
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        Console.WriteLine("Products: ");
        foreach (Product product in _products)
        {
            packingLabel += $" {product.GetProductId()}- {product.GetProductName()}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return _customer.GetName() + "\n" + _customer.GetAddress().GetFullAddress();
    }

}