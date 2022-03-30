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
        [InlineData(1234, 1234)]
        public void ValidatePin_ShouldBe(short pinEntered, short pin)
        {
            // Arrange
            bool expected = true;

            // Act
            bool actual = pinEntered == pin;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
