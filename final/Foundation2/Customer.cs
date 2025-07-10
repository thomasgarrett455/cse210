class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string DisplayCustomerInfo()
    {
        return $"{_name}\nAddress: {_address.DisplayAddress()}";
    }

    public int ShippingPrice()
    {
        return _address.ReturnCountry() ? 35 : 5;

    }
}