using CompositionBankAccount.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CompositionBankAccount.Test
{
    public class PersonTest
    {
        [Theory]
        [InlineData(null)]
        [InlineData("2147")]
        [InlineData("")]
        [InlineData("D")]        
        public void test(string invalidName)
        {
            //Act
            (bool isValid, string errMsg) = Person.ValidateName(invalidName);

            //Assert
            Assert.False(isValid, $"Name {invalidName} should be valid");
        }
    }
}
