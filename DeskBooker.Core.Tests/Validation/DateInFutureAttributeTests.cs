using System;
using DeskBooker.Core.Validation;
using Xunit;

namespace DeskBooker.Core.Tests.Validation
{
    public class DateInFutureAttributeTests
    {
        [Theory]
        [InlineData(false, -1)]
        [InlineData(false, 0)]
        [InlineData(true, 1)]
        public void ShouldValidateDateIsInFuture(bool expectedIsValid, int secondsToAdd)
        {
            //Arrange
            var initialDate = DateTime.Now;
            var updatedDate = initialDate.AddSeconds(secondsToAdd);
            var attribute = new DateInFutureAttribute(() => initialDate);

            //Act
            bool isValid = attribute.IsValid(updatedDate);

            //Assert
            Assert.Equal(expectedIsValid, isValid);
        }

        [Fact]
        public void ShouldHaveExpectedErrorMessage()
        {
            string expectedMessage = "Date must be in the future";

            var attribute = new DateInFutureAttribute();

            Assert.Equal(attribute.ErrorMessage, expectedMessage);
        }
    }
}