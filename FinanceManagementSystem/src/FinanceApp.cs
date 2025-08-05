using FinanceManagementSystem.src.interfaces;

namespace FinanceManagementSystem.src
{
    public class FinanceApp
    {
        private List<Transaction> _transactions = new();

        public void Run()
        {
            SavingsAccount saviour1 = new("beGre4t", 1000);

            Transaction transaction1 = new(1, DateTime.Now, 300, "Groceries");
            Transaction transaction2 = new(2, DateTime.Now, 200, "Utilities");
            Transaction transaction3 = new(3, DateTime.Now, 100, "Entertainment");

            ITransactionProcessor momo = new MobileMoneyProcessor();
            ITransactionProcessor bank = new BankTransferProcessor();
            ITransactionProcessor crypto = new CryptoWalletProcessor();

            momo.Process(transaction3);
            bank.Process(transaction2);
            crypto.Process(transaction1);

            saviour1.ApplyTransaction(transaction3);
            saviour1.ApplyTransaction(transaction2);
            saviour1.ApplyTransaction(transaction1);

            _transactions.Add(transaction3);
            _transactions.Add(transaction2);
            _transactions.Add(transaction1);
        }
    }
}