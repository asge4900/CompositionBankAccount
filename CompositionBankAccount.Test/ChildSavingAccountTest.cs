using CompositionBankAccount.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CompositionBankAccount.Test
{
    public class ChildSavingAccountTest
    {
        [Fact]
        public void test()
        {
            Transaction transaction = new Transaction("", "", 1, DateTime.Now);


            List<Transaction> transactions = new List<Transaction>()
            {
                transaction
            };

            ChildSavingAccount childSavingAccount = new ChildSavingAccount("", 4, DateTime.Now, 4, transactions, "", 7);

            DateTime exptedDate = DateTime.Now.AddYears(7);

            DateTime actualDate = childSavingAccount.CanBeWithDrawedFrom();

            Assert.Equal(exptedDate, actualDate);
        }
    }
}
