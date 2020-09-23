using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPrinciples
{
    public class PaymentService
    {
        private ICollection<PaymentAccount> PaymentAccounts { get; } = new List<PaymentAccount> { new PaymentAccount(1), new PaymentAccount(2) };

        public PaymentAccount FindPaymentAccount(int id)
        {
            return PaymentAccounts.SingleOrDefault(x => x.Id == id);
        }

        public bool Charge(int paymentAccountId, float amount)
        {
            var paymentAccount = FindPaymentAccount(paymentAccountId);
            if (paymentAccount == null)
                return false;

            return paymentAccount.Charge(amount);
        }

        public void Fund(int paymentAccountId, float amount)
        {
            var paymentAccount = FindPaymentAccount(paymentAccountId);
            if (paymentAccount == null)
                return;
            paymentAccount.Fund(amount);
        }
    }
}
