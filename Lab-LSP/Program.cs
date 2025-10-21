namespace Lab_LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount checking = new BankAccount();
            checking.Deposit(200);
            PaymentProcessor.PayBills(checking); // Works fine

            BankAccount deposit = new FixedTermDepositAccount { MaturityDate = DateTime.Now.AddMonths(6) };
            deposit.Deposit(200);
            PaymentProcessor.PayBills(deposit); // Exception! Violates LSP
        }
    }
}
