using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionBankAccount.Entities
{
    public class ChildSavingAccount: Account
    {
        private string childSsn;
        private int yearsLocked;

        public ChildSavingAccount(int id, string accountNumber, decimal balance, DateTime created, decimal creditLimit, List<Transaction> transactions, string childSsn, int yearsLocked)
            :base(id, accountNumber, balance, created, creditLimit, transactions)
        {
            ChildSsn = childSsn;
            YearsLocked = yearsLocked;
        }
        public ChildSavingAccount(string accountNumber, decimal balance, DateTime created, decimal creditLimit, List<Transaction> transactions, string childSsn, int yearsLocked)
            :this(default, accountNumber, balance, created, creditLimit, transactions, childSsn, yearsLocked)
        {
            
        }

        public string ChildSsn { get => childSsn; set => childSsn = value; }
        public int YearsLocked { get => yearsLocked; set => yearsLocked = value; }

        public DateTime CanBeWithDrawedFrom()
        {
            return created.AddYears(7);
        }

        public void WithDraw(decimal amount)
        {

        }
    }
}
