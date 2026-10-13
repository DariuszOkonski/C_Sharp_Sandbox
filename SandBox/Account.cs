namespace SandBox
{
    public class Account
    {
        public string AccountNumber { get; private set; }
        public decimal Balance { get; private set; }

        public Account(string accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount: C}. New balance is {Balance:C}.");
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount:C}. New balance is {Balance:C}.");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
    }

    public sealed class SavingsAccount : Account
    {
        public SavingsAccount(string accountNumber, decimal initialBalance)
            : base(accountNumber, initialBalance)
        {
        }

        public override void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                base.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Insufficient funds. Cannot withdraw from a savings accounts.");
            }
        }
    }
}
