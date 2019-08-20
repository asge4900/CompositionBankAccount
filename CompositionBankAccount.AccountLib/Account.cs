using System;
using System.Collections.Generic;

namespace CompositionBankAccount.Entities
{
    public class Account: Entity
    {
        #region Fields
        protected string accountNumber;
        protected decimal balance;
        protected DateTime created;
        protected decimal creditlimit;
        protected List<Transaction> transactions;
        #endregion

        /// <summary>
        /// Initializes a new instance of this class. Use for existing records.
        /// </summary>
        /// <param name="id">The persistence id genereated by database</param>
        /// <param name="balance">The balance of the acount.</param>
        /// <param name="created">The date</param>

        #region Constructors
        public Account()
        {

        }
        public Account(int id, string accountNumber, decimal balance, DateTime created, decimal creditLimit, List<Transaction>transactions)
            :base(id)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            Created = created;
            CreditLimit = creditlimit;
            Transactions = transactions;
        }
        public Account(string accountNumber, decimal balance, DateTime created, decimal creditLimit, List<Transaction> transactions)
            :this(default, accountNumber, balance, created, creditLimit, transactions)
        {

        }
        #endregion

        #region Properties  
        public string AccountNumber { get => accountNumber; set => accountNumber = value; }
        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                var validationResult = ValidateBalance(value);
                if (!validationResult.isValid)
                {
                    throw new ArgumentOutOfRangeException(validationResult.errorMessage);
                }
                if (balance != value)
                    balance = value;
            }
        }
        public DateTime Created { get => created; set => created = value; }
        public decimal CreditLimit { get => creditlimit; set => creditlimit = value; }
        public List<Transaction> Transactions { get => transactions; set => transactions = value; }
        #endregion

        #region Methods
        public Account(decimal initalBalance)
        {

        }
        public virtual void Withdraw(decimal amount)
        {
            string message = "";
            if (amount <= 0)
                throw new ArgumentException("Hæv et beløb der er større end 0");
            else if (amount > 25000)
                message = "Du kan maks hæve 25000";
            else
                balance -= amount;
        }
        public virtual void Desposit(decimal amount)
        {
            string message = "";
            if (amount <= 0)
                message = "Indsæt et beløb der er større end 0";
            else if (amount > 25000)
                message = "Indsæt et beløb der er mindre end 25000";
            else
                balance += amount;
        }
        public int GetDaysSinceCreation()
        {
            return (DateTime.Now - created).Days;
        }
        public static (bool isValid, string errorMessage) ValidateBalance(decimal balance)
        {
            if (balance < -999_999_999)
                return (false, "Saldoen er for lav");
            else if (balance > 999_999_999)
                return (false, "Saldoen er for høj");
            else
                return (true, "");
        }
        public static (bool isValid, string errorMessage) ValidateAccountNumber(string accountNumber)
        {
            if (!accountNumber.StartsWith("123412345"))
            {
                return (false, "Must start with 123412345");
            }
            else if (accountNumber.Length != 19)
            {
                return (false, "Must be 19 characters");
            }
            else if (!int.TryParse(accountNumber, out int result))
            {
                return (false, "Only numbers");
            }
            return (true, "");
        }
        public static (bool isValid, string errorMessage) ValidateCreatedDate(DateTime createdDate)
        {
            return (true, "");
        }
        public static (bool isValid, string errorMessage) ValidateCreditLimit(decimal creditLimit)
        {
            return (true, "");
        }
        #endregion
    }
}
