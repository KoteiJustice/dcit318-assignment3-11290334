using FinanceManagementSystem.src.interfaces;

namespace FinanceManagementSystem.src
{
    public class MobileMoneyProcessor : ITransactionProcessor
    {
        public void Process(Transaction transaction)
        {
            Console.WriteLine("Transaction received with amount of :" + transaction.Amount + " with category " + transaction.Category);
        }
    }
}