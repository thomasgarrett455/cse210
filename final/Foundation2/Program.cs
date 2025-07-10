using System;

class Program
{
    static void Main(string[] args)
    {
        Address myAddress = new Address("123 Street", "Rexburg", "Idaho", "USA");
        Customer myCustomer = new Customer("Billy Joe", myAddress);
        Product myProduct = new Product("12oz Bottles", 12345, 1, 1000);
        Product myProduct2 = new Product("16oz Bottles", 54321, 2, 1000);
        Product myProduct3 = new Product("Face Wash", 15243, 1, 3000);
        Orders myOrders = new Orders(myCustomer);
        myOrders.AddProduct(myProduct);
        myOrders.AddProduct(myProduct2);
        myOrders.AddProduct(myProduct3);

        Product myProduct4 = new Product("Smiley Stickers", 51423, 5, 10000);
        Product myProduct5 = new Product("Frowny Stickers", 54123, 5, 10000);
        Product myProduct6 = new Product("Face Wash", 15243, 1, 3000);
        Orders myOrders1 = new Orders(myCustomer);
        myOrders1.AddProduct(myProduct4);
        myOrders1.AddProduct(myProduct5);
        myOrders1.AddProduct(myProduct6);

        Console.WriteLine($"{myOrders.PackingLabel()}");
        Console.WriteLine($"{myOrders.ShippingLabel()}");
        Console.WriteLine(myOrders.TotalCost());
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"{myOrders1.PackingLabel()}");
        Console.WriteLine($"{myOrders1.ShippingLabel()}");
        Console.WriteLine(myOrders1.TotalCost());
    }
}