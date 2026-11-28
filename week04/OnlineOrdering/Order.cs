public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

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
        int shippingCost = 0;
        double totalProductCost = 0;

        foreach (Product product in _products)
        {
            double productCost = product.ProductTotalCost();
            totalProductCost += productCost;
        }

        if (_customer.IsInUsa() == true)
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        return totalProductCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        string displayProduct = "";

        foreach (Product product in _products)
        {
            string id = product.GetDisplayProductId();
            string pName = product.GetDiplayProductName();
            displayProduct += pName + " | " + id + "\n";

        }

        return displayProduct;
        // Name and Id product of each product
    }

    public string GetShippingLabel()
    {
        return _customer.GetShippingLabel();
    }
}
