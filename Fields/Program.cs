using System.Collections.Generic;

namespace Fields
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id): this()
        {
            this.Id = id;
        }

        public Customer(int id, string name): this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            //...TODO:  CODE GOES HERE
        }
    }

    public class Order
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
