using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ATM_Machine.tests
{
    public class AccountTests
    {
        [Theory]
        [InlineData("Marcus Jensen", 100)]
        public void GenerateCard_ShouldBe(string name, decimal balance)
        {
            // Arrange
            bool expected = true;

            // Act
            Card card = new Card(
                (ushort)new Random().Next(1000, 9999 + 1),
                (ulong)new Random().NextInt64(1000000000000000, 9999999999999999 + 1),
                name,
                (ushort)new Random().Next(100, 999 + 1),
                new Account(new Customer(name), balance)
                );

            bool actual = card.GetType().Name.Equals("Card");

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
