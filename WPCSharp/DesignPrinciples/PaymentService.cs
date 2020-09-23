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

        public bool DeleteCustomer (PaymentAccount param)
        {
            return PaymentAccounts.Remove(param);
        }

        public bool Charge(int paymentAccountId, float amonut)
        {
            var paymentAccount = PaymentAccounts.SingleOrDefault(x => x.Id == paymentAccountId);
            if (paymentAccount == null)
                return false;
            if (paymentAccount.Incomes - paymentAccount.Outcomes + paymentAccount.AllowedDebit < amonut)
                return false;

            paymentAccount.Outcomes += amonut;
            return true;
        }

        public void Fund(int paymentAccountId, float amonut)
        {
            var paymentAccount = PaymentAccounts.SingleOrDefault(x => x.Id == paymentAccountId);
            if (paymentAccount == null)
                return;
            paymentAccount.Incomes += amonut;
        }
        
        public float? GetBalance(int paymentAccountId)
        {
            var customer = PaymentAccounts.Where(x => x.Id == paymentAccountId).SingleOrDefault();
            return customer?.Incomes - customer?.Outcomes;
        }
    }
}
