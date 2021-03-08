using System;
using DeskBooker.Core.Processor;
using Xunit;

namespace DeskBooker.Core.Tests.Processor
{
    public class DeskBookingRequestProcessorTests
    {
        private readonly DeskBookingRequest _request;
        private readonly DeskBookingRequestProcessor _processor;
        public DeskBookingRequestProcessorTests()
        {
            _request = new DeskBookingRequest
            {
                FirstName = "Ronny",
                LastName = "Carrasquel",
                Email = "ronnyjcarrasquel@gmail.com",
                Date = new DateTime(1995, 9, 9)
            };
            _processor = new DeskBookingRequestProcessor();
        }
        [Fact]
        public void ShouldReturnDeskBookingResultWithRequestValues()
        {
            //Act
            DeskBookingResult result = _processor.BookDesk(_request);
            //Assert
            Assert.NotNull(result);
            Assert.Equal(_request.FirstName, result.FirstName);
            Assert.Equal(_request.LastName, result.LastName);
            Assert.Equal(_request.Email, result.Email);
            Assert.Equal(_request.Date, result.Date);
        }
        [Fact]
        public void ShouldThrowExceptionIfRequestIsNull()
        {
            var exception = Assert.Throws<ArgumentNullException>(() => _processor.BookDesk(null));

            Assert.Equal("request", exception.ParamName);            
        }
    }
}
