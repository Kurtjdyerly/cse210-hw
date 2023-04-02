using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("Kurt Dyerly");
        Customer customer2 = new Customer("Sam Howarth");
        Customer customer3 = new Customer("Dallin Hatton");

        Address address1 = new Address();
        address1.SetAddress("722 daisy ln");
        address1.SetCity("Pinon hills");
        address1.SetCountry("USA");
        address1.SetState("CA");
        Address address2 = new Address();
        address2.SetAddress("156 W 4th S");
        address2.SetCity("Rexburg");
        address2.SetCountry("USA");
        address2.SetState("CA");
        Address address3 = new Address();
        address3.SetAddress("1234 Rockforth pl");
        address3.SetCity("Fremont");
        address3.SetCountry("CANADA");
        address3.SetState("Calgary");

        customer1.SetAddress(address1);
        customer2.SetAddress(address2);
        customer3.SetAddress(address3);

        Product product1 = new Product("Iphone", 354650, 999.99);
        Product product2 = new Product("Ear Buds", 684651, 99.99);
        Product product3 = new Product("Baby wipes", 54354, 15.75, 3);
        Product product4 = new Product("Charlston Chews", 568432, 1.25, 36);
        Product product5 = new Product("Duster", 354465, 57.98);
        Product product6 = new Product("RAM 16GB", 357487, 35.99, 2);
        Product product7 = new Product("Plush toy", 12657, 21.10, 3);
        Product product8 = new Product("Fidget Slug", 56421, 9.55, 2);

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);
        Order order3 = new Order(customer3);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        order2.AddProduct(product6);
        order2.AddProduct(product5);
        order2.AddProduct(product4);

        order3.AddProduct(product5);
        order3.AddProduct(product8);
        order3.AddProduct(product7);


        order1.PrintPackingLabel();
        Console.WriteLine();
        order1.PrintShippingLabel();
        Console.WriteLine("------------------------");
        order2.PrintPackingLabel();
        Console.WriteLine();
        order2.PrintShippingLabel();
        Console.WriteLine("------------------------");
        order3.PrintPackingLabel();
        Console.WriteLine();
        order3.PrintShippingLabel();
        Console.WriteLine("------------------------");
    }
}