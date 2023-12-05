using System;
using System.Diagnostics;

namespace Тумаков_14лаб
{
    public class BankAccount
    {
        private string accountNumber;
        private double balance;

        public BankAccount(string accountNumber, double balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        [Conditional("DEBUG_ACCOUNT")]
        public void DumpToScreen()
        {
            Console.WriteLine("Детали банковского счета:");
            Console.WriteLine("Номер счета: " + accountNumber);
            Console.WriteLine("Баланс: " + balance);
        }
    }   
}
