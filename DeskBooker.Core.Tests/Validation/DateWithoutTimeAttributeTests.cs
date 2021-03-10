using System;
using DeskBooker.Core.Validation;
using Xunit;

namespace DeskBooker.Core.Tests.Validation
{
	public class DateWithoutTimeAttributeTests
	{
		[Theory]
		[InlineData(0, 0, 0, true)]
		[InlineData(1, 0, 0, false)]
		[InlineData(0, 1, 0, false)]
		[InlineData(0, 0, 1, false)]
		public void ShouldNotHaveTime(int hour, int minutes, int seconds, bool expectedIsValid)
		{
			var dateTime = new DateTime(2012, 12, 12, hour, minutes, seconds);

			var attribute = new DateWithoutTimeAttribute();

			var isValid = attribute.IsValid(dateTime);

			Assert.Equal(isValid, expectedIsValid);
		}
        [Fact]
		public void ShouldHaveExpectedErrorMessage()
		{
			var attribute = new DateWithoutTimeAttribute();
			string errorMessage = "Date must not contain time";
            
			Assert.Equal(attribute.ErrorMessage, errorMessage);
		}
	}
}