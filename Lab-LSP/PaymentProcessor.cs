using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_LSP
{
    public static class PaymentProcessor
    {
        /// <summary>
        /// Pays a $100 bill. This client is written ONLY against the
        /// BankAccount contract: it checks the precondition (enough balance)
        /// before calling Withdraw, so by that contract the call must succeed.
        /// </summary>
        public static void PayBills(BankAccount account)
        {
            const decimal billAmount = 100m;

            if (account.Balance >= billAmount)
            {
                account.Withdraw(billAmount);
                Console.WriteLine("Bill paid successfully!");
            }
            else
            {
                Console.WriteLine("Insufficient funds; bill not paid.");
            }
        }
    }
}
