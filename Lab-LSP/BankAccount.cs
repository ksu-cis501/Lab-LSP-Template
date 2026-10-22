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

        /// <summary>
        /// Withdraws money from the account.
        /// CONTRACT:
        ///   Precondition:  0 &lt; amount &lt;= Balance
        ///   Postcondition: Balance decreases by exactly amount.
        ///   Guarantee:     If the precondition holds, the withdrawal succeeds.
        ///                  Exceptions are thrown only when the precondition is not met.
        /// </summary>
        public virtual void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Amount must be positive.");

            if (amount > Balance)
                throw new InvalidOperationException("Insufficient funds.");

            Balance -= amount;
        }

        /// <summary>
        /// Deposits money into the account.
        /// Precondition: amount &gt; 0
        /// </summary>
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Amount must be positive.");

            Balance += amount;
        }
    }
}
