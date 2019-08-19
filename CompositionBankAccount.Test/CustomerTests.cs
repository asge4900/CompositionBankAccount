using CompositionBankAccount.Entities;
using System.Collections.Generic;
using Xunit;

namespace CompositionBankAccount.Test
{
    public class CustomerTests
    {
        [Fact]
        public void GetDebts_ReturnNegativeNumber()
        {
            Account account1 = new Account()
            {
                Balance = -5000
            };

            Account account2 = new Account()
            {
                Balance = 500
            };


            List<Account> accounts = new List<Account>()
            {
                account1, account2
            };

            Customer customer = new Customer(accounts);

            decimal exptectedDebt = 5000;

            decimal actualDebt = customer.GetDebts();

            Assert.Equal(exptectedDebt, actualDebt);
        }

        [Fact]
        public void GetAssets_ReturnZeroOrAbove()
        {
            Account account1 = new Account()
            {
                Balance = 5000
            };

            Account account2 = new Account()
            {
                Balance = 500
            };


            List<Account> accounts = new List<Account>()
            {
                account1, account2
            };

            Customer customer = new Customer(accounts);

            decimal exptectedDebt = 5500;

            decimal actualDebt = customer.GetAssets();

            Assert.Equal(exptectedDebt, actualDebt);
        }


        [Fact]
        public void GetTotal()
        {
            Account account1 = new Account()
            {
                Balance = 5000
            };

            Account account2 = new Account()
            {
                Balance = 500
            };

            Account account3 = new Account()
            {
                Balance = -600
            };

            List<Account> accounts = new List<Account>()
            {
                account1, account2, account3
            };

            Customer customer = new Customer(accounts);

            decimal exptectedDebt = 4900;

            decimal actualDebt = customer.GetTotalBalance();

            Assert.Equal(exptectedDebt, actualDebt);
        }


        [Fact]
        public void RatingShouldReturn1()
        {
            Account account1 = new Account()
            {
                Balance = -3_000_000
            };

            Account account2 = new Account()
            {
                Balance = 2_000_000
            };          

            List<Account> accounts = new List<Account>()
            {
                account1, account2
            };

            Customer customer = new Customer(accounts);

            int exptectedRating = 1;

            int actualRating = customer.Rating;

            Assert.Equal(exptectedRating, actualRating);
        }

        [Fact]
        public void RatingShouldReturn2()
        {
            Account account1 = new Account()
            {
                Balance = -3_000_000
            };

            Account account2 = new Account()
            {
                Balance = 1_000_000
            };

            List<Account> accounts = new List<Account>()
            {
                account1, account2
            };

            Customer customer = new Customer(accounts);

            decimal exptectedRating = 2;

            decimal actualRating = customer.Rating;

            Assert.Equal(exptectedRating, actualRating);
        }

        [Fact]
        public void RatingShouldReturn3()
        {
            Account account1 = new Account()
            {
                Balance = -260_000
            };

            Account account2 = new Account()
            {
                Balance = 50_000
            };
            
            List<Account> accounts = new List<Account>()
            {
                account1, account2
            };

            Customer customer = new Customer(accounts);

            decimal exptectedRating = 3;

            decimal actualRating = customer.Rating;

            Assert.Equal(exptectedRating, actualRating);
        }

        [Fact]
        public void RatingShouldReturn4()
        {
            Account account1 = new Account()
            {
                Balance = -50
            };

            Account account2 = new Account()
            {
                Balance = 500
            };            

            List<Account> accounts = new List<Account>()
            {
                account1, account2
            };

            Customer customer = new Customer(accounts);

            decimal exptectedRating = 4;

            decimal actualRating = customer.Rating;

            Assert.Equal(exptectedRating, actualRating);
        }

        [Fact]
        public void RatingShouldReturn5()
        {
            Account account1 = new Account()
            {
                Balance = -5000
            };

            Account account2 = new Account()
            {
                Balance = 500
            };

          
            List<Account> accounts = new List<Account>()
            {
                account1, account2
            };

            Customer customer = new Customer(accounts);

            decimal exptectedRating = 5;

            decimal actualRating = customer.Rating;

            Assert.Equal(exptectedRating, actualRating);
        }
    }
}
