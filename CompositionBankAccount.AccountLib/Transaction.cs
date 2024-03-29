﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionBankAccount.Entities
{
    public class Transaction: Entity
    {
        #region Fields
        protected string sender;
        protected string receiver;
        protected decimal amount;
        protected DateTime timestamp;

       
        #endregion

        #region Constructors
        public Transaction(int id, string sender, string reciever, decimal amount, DateTime timestamp)
            :base(id)
        {
           
        }
        public Transaction(string sender, string reviever, decimal amount, DateTime timestamp)        
        {

        }
        #endregion        

        #region Methods
        public static (bool isValid, string errMsg) ValidateTimeStamp(DateTime timestamp)
        {
            return (true, "");
        }
        public static (bool isValid, string errMsg) ValidateAmount(decimal amount)
        {
            return (true, "");
        }
        #endregion
    }
}
