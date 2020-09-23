using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPrinciples
{
    public class CustomersServices
    {
        private ICollection<Customer> Customers { get; } = new List<Customer> { new Customer(1), new Customer(2) };

        public Customer Find(int id)
        {
            return Customers.SingleOrDefault(x => x.Id == id);
        }

    }
}
