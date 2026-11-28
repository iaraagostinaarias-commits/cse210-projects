public class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public Customer(string name, Address address)
    {
        _customerName = name;
        _customerAddress = address;
    }

    public bool IsInUsa()
    {
        return _customerAddress.IsInUsa();
    }

    public string GetShippingLabel()
    {
        return _customerName + " | " + _customerAddress.GetDisplayAddress();
    }
}
