using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionBankAccount.Entities
{
    public class ChildSavingAccount: Account
    {
        #region Fields
        private string childSsn;
        private int yearsLocked;
        #endregion

        #region Constructors
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
        #endregion

        #region Properties
        public string ChildSsn { get => childSsn; set => childSsn = value; }
        public int YearsLocked { get => yearsLocked; set => yearsLocked = value; }
        #endregion

        #region Methods
        public DateTime CanBeWithDrawedFrom()
        {
            return created.AddYears(yearsLocked);
        }
        public override void Withdraw(decimal amount)
        {
            if (created.AddYears(yearsLocked) < DateTime.Now)
            {
                throw new Exception("");
            }
            base.Withdraw(amount);
        }
        public override void Desposit(decimal amount)
        {          
            base.Desposit(amount);
        }        
        #endregion
    }
}
