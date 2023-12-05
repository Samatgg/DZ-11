using System.Collections.Generic;

namespace Тумаков_13лаб
{
    public enum BankType
    {
        Сберегательный,
        Зарплатный,
        Общий
    }

    public class BankAccount
    {
        private int accountNumber;
        private BankType accountType;
        private decimal balance;
        public int AccountNumber
        {
            get { return accountNumber; }
        }
        public BankType AccountType
        {
            get { return accountType; }
        }
        public decimal Balance
        {
            get { return balance; }
        }
        /// <summary>
        /// Держатель банковского счета
        /// </summary>
        public string BankAccountHolder { get; set; }

        /// <summary>
        /// Транзакции
        /// </summary>
        private List<BankTransaction> transactions;
        public BankAccount()
        {
            transactions = new List<BankTransaction>();
        }
        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public BankTransaction this[int index]
        {
            get { return transactions[index]; }
            set { transactions[index] = value; }
        }
        public BankAccount(int accountNumber, decimal balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }
        
    }

}
