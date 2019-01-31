namespace Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create New Customer
            var customer = new Customer();

            //  Add Orders to the Customer
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            //  Display Orders in Shopping Cart
            System.Console.WriteLine(customer.Orders.Count);

            //  Promote the Customer
            customer.Promote();

            //  Display Orders in Shopping Cart
            System.Console.WriteLine(customer.Orders.Count);
        }
    }
}
