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
            Account account = new Account()
            {
                Created = DateTime.Now
            };

            //ChildSavingAccount childSavingAccount = new ChildSavingAccount("", 4, DateTime.Now, 4, "", 7);


        }
    }
}
