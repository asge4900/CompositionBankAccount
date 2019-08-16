using CompositionBankAccount.Entities;
using System;
using System.Collections.Generic;

namespace Test.Console
{
    class Program
    {
        static void Main(string[] args)
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
            

            decimal actualDebt = customer.GetDebts();

            System.Console.WriteLine(actualDebt);

            System.Console.ReadLine();
        }
    }
}
