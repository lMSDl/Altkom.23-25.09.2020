using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPrinciples
{
    public class PaymentAccount
    {
        public int Id { get; }
        public string CustomerName { get; set; }
        public float Incomes { get; private set; }
        public float Outcomes { get; private set; }
        public float AllowedDebit { get; set; }

        public PaymentAccount(int id)
        {
            Id = id;
        }

        public bool Charge(float amount)
        {
            if (Incomes - Outcomes < amount)
                return false;
            Outcomes += amount;
            return true;
        }

        public void Fund(float amount)
        {
            Incomes += amount;
        }
    }

}