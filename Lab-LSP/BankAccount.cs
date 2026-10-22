using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_LSP
{
    public class BankAccount
    {
        public decimal Balance { get; protected set; }

        ///             (1)    (2)       (3)
        /// Contract: if 0 < amount <= Balance, the withdrawal succeeds
        /// and Balance decreases by exactly amount.
        public virtual void Withdraw(decimal amount)
        {
            if (amount <= 0) // (1)
                throw new ArgumentException("Amount must be positive.");

            if (amount > Balance) // (3)
                throw new InvalidOperationException("Insufficient funds.");
            (2)
            Balance -= amount;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Amount must be positive.");

            Balance += amount;
        }
    }
}
