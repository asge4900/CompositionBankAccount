using CompositionBankAccount.Entities;
using System;
using Xunit;

namespace CompositionBankAccount.Test
{
    public class AccountTest
    {
        //[Fact]
        //public void validate()
        //{

        //    Account account = new Account(1, 100, DateTime.Today);

        //}


        [Fact]
        public void Validate2()
        {
            int expectedDays = 1;

            Account account = new Account();
            account.Created = DateTime.Now.AddDays(-1);

            int actualDays = account.GetDaysSinceCreation();

            Assert.Equal(expectedDays, actualDays);
        }

        [Fact]
        public void Validate3()
        {
            decimal expectedBalance = 110;

            Account account = new Account();
            account.Balance = 100;

            account.Desposit(10);

            decimal actualBalance = account.Balance;

            Assert.Equal(expectedBalance, actualBalance);
        }

        [Fact]
        public void Validate4()
        {
            decimal expectedBalance = 90;

            Account account = new Account();
            account.Balance = 100;

            account.Withdraw(10);

            decimal actualBalance = account.Balance;

            Assert.Equal(expectedBalance, actualBalance);
        }


        [Theory]
        [InlineData(-1000000000)]
        [InlineData(1000000000)]
        public void ValidateBalance(decimal invalidbalance)
        {

            (bool isValid, string errMsg) = Account.ValidateBalance(invalidbalance);

            Assert.False(isValid, "Balance should be valid");

        }
    }
}
