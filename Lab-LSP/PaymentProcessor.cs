using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_LSP
{
    public static class PaymentProcessor
    {
        public static void PayBills(BankAccount account)
        {
            account.Withdraw(100);
            Console.WriteLine("Bill paid successfully!");
        }
    }
}
