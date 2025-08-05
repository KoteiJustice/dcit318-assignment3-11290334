namespace FinanceManagementSystem.src
{
    public class Account
    {
        string AccountNumber;
        public decimal Balance;

        public Account(string accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }
        public virtual void ApplyTransaction(Transaction transaction)
        {
            Balance -= transaction.Amount;
        }
    }
}