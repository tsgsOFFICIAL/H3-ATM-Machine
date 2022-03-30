using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ATM_Machine.tests
{
    public class ATMTests
    {
        [Theory]
        [InlineData(50)]
        [InlineData(100)]
        [InlineData(200)]
        [InlineData(400)]
        [InlineData(600)]
        [InlineData(-600)]
        public void Deposit_ShouldBe(decimal amount)
        {
            // Arrange
            bool expected = true;

            // Act
            bool actual = new ATM().Deposit(new Card(1234, 1234123412341234, "", 123, new Account(new Customer(""), 500)), amount);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(50)]
        [InlineData(100)]
        [InlineData(200)]
        [InlineData(400)]
        [InlineData(600)]
        [InlineData(-600)]
        public void Withdraw_ShouldBe(decimal amount)
        {
            // Arrange
            bool expected = true;

            // Act
            bool actual = new ATM().Withdraw(new Card(1234, 1234123412341234, "", 123, new Account(new Customer(""), 500)), amount);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
