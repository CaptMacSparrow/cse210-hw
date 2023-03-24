public class Order
{
    public string _customer;
    public List<Product> _products = new List<Product>();
    public List<Customer> _customers = new List<Customer>();

    public Order(string customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public string GetPackingLabel() //name and product ID of each product in order
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += product.GetProductName() + $" #{product.GetProductID()}" + "\n" ;

        }
        return packingLabel;
    }

    public string GetShippingLabel() //name and address of customer
    {
        string shippingLabel = "";
        foreach (Customer customer in _customers)
        {
            shippingLabel = customer.GetName() + "\n" + customer.GetAddress() + "\n";
        }
        return shippingLabel;
    }

    public double GetTotalPrice(bool _inUSAx) 
    {
        double totalPrice = 0;
        
        foreach (Product product in _products) 
        {
            totalPrice += product.GetPrice();
        }
        foreach (Customer customer in _customers)
        {
            if (_inUSAx) 
            {
                totalPrice += 5;
            } 
        
            else 
            {
                totalPrice += 35;
            }
        }
        
        return totalPrice;
    }

}

