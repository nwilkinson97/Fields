namespace Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();

            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            System.Console.WriteLine(customer.Orders.Count);

            customer.Promote();

            System.Console.WriteLine(customer.Orders.Count);
        }
    }
}
