using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionBankAccount.Entities
{
    public class Customer: Person
    {
        #region Fields
        private List<Account> accounts;
        #endregion

        #region Constructors
        public Customer(List<Account>accounts)
        {
            Accounts = accounts;
        }
        public Customer(int id, string firstname, string lastname, string ssn, List<Account>accounts)
            :base(firstname, lastname, ssn)
        {
            Accounts = accounts;
        }
        public Customer(string firstname, string lastname, string ssn, List<Account> accounts)
            :this(default, firstname, lastname, ssn, accounts)
        {

        }
        #endregion

        #region Properties
        public List<Account> Accounts { get => accounts; set => accounts = value; }
        public decimal AmountFee { get; set; }
        public int MonthlyFreeTransactions { get; set; }
        public decimal TransactionFee { get; set; }
        public int Rating {
            get
            {
                if (GetDebts() > 2_500_000 && GetAssets() > 1_250_000)
                    return 1;
                else if (GetDebts() > 2_500_000 && GetAssets() >= 50_000 && GetAssets() <= 1_250_000)
                    return 2;
                else if (GetDebts() >= 250_000 && GetDebts() <= 2_500_000 && GetAssets() >= 50_000 && GetAssets() <= 1_250_000)
                    return 3;
                else if (GetDebts() > 0 && GetDebts() < 250_000 && GetAssets() > 0 && GetAssets() < 50_000 && GetDebts() < GetAssets())
                    return 4;
                else if (GetDebts() > 0 && GetDebts() < 250_000 && GetAssets() > 0 && GetAssets() < 50_000 && GetDebts() > GetAssets())
                    return 5;
                else
                    return 0;
            }
        }
        #endregion

        #region Methods
        public decimal GetDebts()
        {
            decimal debt = 0;
            foreach (var account in accounts)
            {
                if(account.Balance < 0)
                    debt -= account.Balance;
            }
            return debt;
        }
        public decimal GetAssets()
        {
            decimal debt = 0;
            foreach (var account in accounts)
            {
                if (account.Balance > 0)
                    debt += account.Balance;
            }
            return debt;
        }
        public decimal GetTotalBalance()
        {
            return GetDebts() * -1 + GetAssets();
        }
        public decimal GetTotalFeesFor(DateTime year)
        {
            return 0;
        }
        public decimal GetTotalFeesFor(DateTime from, DateTime to)
        {
            return 0;
        }
        #endregion
    }
}
