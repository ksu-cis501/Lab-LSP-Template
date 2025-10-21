using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_LSP
{
    public class FixedTermDepositAccount: BankAccount
    {
        public DateTime MaturityDate { get; set; }

        public override void Withdraw(decimal amount)
        {
            if (DateTime.Now < MaturityDate)
                throw new InvalidOperationException("Cannot withdraw before maturity date.");

            base.Withdraw(amount);
        }
    }
}
