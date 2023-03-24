public class Product
{
    private string _productName;
    private int _productID;
    private double _productPrice;
    private int _productNum;

    public Product(string productName, int productID, double productPrice, int productNum)
    {
        _productName = productName;
        _productID = productID;
        _productPrice = productPrice;
        _productNum = productNum;
    }
    public double GetPrice()
    {
        double price = _productPrice * _productNum;
        return price;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public int GetProductID()
    {
        return _productID;
    }

    public int GetProductNum()
    {
        return _productNum;
    }
    
}