namespace Lab_LSP
{
    internal class Program
    {
        public static void Main()
                {
                    Console.WriteLine("--- Test 1: BankAccount with $200 ---");
                    BankAccount checking = new BankAccount();
                    checking.Deposit(200);
                    PaymentProcessor.PayBills(checking);            // Works
        
                    Console.WriteLine("--- Test 2: BankAccount with $50 ---");
                    BankAccount low = new BankAccount();
                    low.Deposit(50);
                    PaymentProcessor.PayBills(low);                 // Handled gracefully
        
                    Console.WriteLine("--- Test 3: FixedTermDepositAccount with $200 ---");
                    // Fixed date so the result does not depend on when you run the program.
                    BankAccount deposit = new FixedTermDepositAccount
                    {
                        MaturityDate = new DateTime(2099, 1, 1)
                    };
                    deposit.Deposit(200);
                    PaymentProcessor.PayBills(deposit);             // Exception! Why?
                }
        }
 }
