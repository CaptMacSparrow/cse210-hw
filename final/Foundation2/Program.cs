using System;

class Program
{
    static void Main(string[] args)
    {
        //order 1
        Address a1 = new Address("90 West St", "New York", "NY", "USA");
        Customer c1 = new Customer("Frank White", a1.GetFullAddress());
        Product p1 = new Product("Pencil", 999999, .99, 5);
        Product p2 = new Product("Pen", 888888, 1.99, 2);
        
        //order 2
        Address a2 = new Address("123 Viva St", "Chihuahua", "Chih.", "MEX");
        Customer c2 = new Customer("Brandon Moreno", a2.GetFullAddress());
        Product pp1 = new Product("Paper", 123654, 6.99, 2);
        Product pp2 = new Product("Desk Fan", 987654, 19.99, 1);

        List<Product> myList = new List<Product>();
        List<Product> myList2 = new List<Product>();


        Order o1 = new Order(c1.GetName(), myList);
        o1._customer = c1.GetName();
        o1._products.Add(p1);
        o1._products.Add(p2);
        o1._customers.Add(c1);

        Order o2 = new Order(c2.GetName(), myList2);
        o2._customer = c2.GetName();
        o2._products.Add(pp1);
        o2._products.Add(pp2);
        o2._customers.Add(c2);

        string _strPackingLabel = o1.GetPackingLabel();
        Console.WriteLine();        
        Console.WriteLine("Order #01");
        Console.WriteLine();
        Console.WriteLine("Packing Label:");
        Console.WriteLine(_strPackingLabel);
        
        string _strShippingLabel = o1.GetShippingLabel();
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(_strShippingLabel);
        bool _inUSAx = a1.IsInUSA();

        double _dbTotalPrice = o1.GetTotalPrice(_inUSAx);
        Console.WriteLine("Total Price:");
        Console.WriteLine("$" + String.Format("{0:0.00}", _dbTotalPrice));

        string _strPackingLabel2 = o2.GetPackingLabel();
        Console.WriteLine();        
        Console.WriteLine("Order #02");        
        Console.WriteLine();
        Console.WriteLine("Packing Label:");
        Console.WriteLine(_strPackingLabel2);
        
        string _strShippingLabel2 = o2.GetShippingLabel();
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(_strShippingLabel2);
        bool _inUSAxx = a2.IsInUSA();

        double _dbTotalPrice2 = o2.GetTotalPrice(_inUSAxx);
        Console.WriteLine("Total Price:");
        Console.WriteLine("$" + String.Format("{0:0.00}", _dbTotalPrice2));
    }

}