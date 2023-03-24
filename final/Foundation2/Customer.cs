public class Customer
{
    private string _name;
    private string _address;

    public Customer(string name, string address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address;
    }
}