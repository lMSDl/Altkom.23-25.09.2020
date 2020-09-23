﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPrinciples
{
    public class PaymentService
    {
        public bool Charge(Customer customer, float amount)
        {
            if (customer.PaymentAccount == null)
                return false;

            return customer.PaymentAccount.Charge(amount);
        }

        public void Fund(Customer customer, float amount)
        {
            if (customer.PaymentAccount == null)
                return;
            customer.PaymentAccount.Fund(amount);
        }
    }
}
