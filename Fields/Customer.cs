using System.Collections.Generic;

namespace Fields
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders;

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
            //... TODO -> Code Goes Here
            //Orders = new List<Order>();
        }
    }
}
