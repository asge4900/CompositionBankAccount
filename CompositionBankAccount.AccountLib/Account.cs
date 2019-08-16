using System;

namespace CompositionBankAccount.Entities
{
    public class Account
    {
        #region Fields
        private int id;
        private decimal balance;
        private DateTime created;
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

        public Account(int id, decimal balance, DateTime created)
        {
            Id = id;
            Balance = balance;
            Created = created;
        }
        #endregion

        #region Properties
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                //if (id < 1)
                //    throw new ArgumentException("Must be higher than zero");                               
                id = value;
            }
        }

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

        public DateTime Created { get { return created; } set { created = value; } }
        #endregion


        #region Methods
        public Account(decimal initalBalance)
        {

        }

        public void Withdraw(decimal amount)
        {
            string message = "";
            if (amount <= 0)
                throw new ArgumentException("Hæv et beløb der er større end 0");
            else if (amount > 25000)
                message = "Du kan maks hæve 25000";
            else
                balance -= amount;
        }

        public void Desposit(decimal amount)
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
        #endregion
    }
}
