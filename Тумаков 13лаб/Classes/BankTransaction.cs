using System;

namespace Тумаков_13лаб
{
    public class BankTransaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }

        public BankTransaction(decimal amount, DateTime date)
        {
            Amount = amount;
            Date = date;
        }
    }
}
