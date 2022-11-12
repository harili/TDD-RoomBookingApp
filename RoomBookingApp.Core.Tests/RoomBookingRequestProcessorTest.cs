using RoomBookingApp.Core.Models;
using RoomBookingApp.Core.Processors;
using Shouldly;
using Xunit;

namespace RoomBookingApp.Core
{
    public sealed class RoomBookingRequestProcessorTest
    {
        [Fact]
        public void Should_Return_Room_Booking_Response_Wit_request_Values()
        {
            //Arrange
            var request = new RoomBookingRequest
            {
                FullName = "Test Name",
                Email = "test@est.com",
                Date = DateTime.Now,
            };

            var processor = new RoomBookingRequestProcessor();

            //Act
            RoomBookingResult result = processor.BookRoom(request);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(request.FullName, result.FullName);
            Assert.Equal(request.Email, result.Email);
            Assert.Equal(request.Date, result.Date);

            result.ShouldNotBeNull();
            result.FullName.ShouldBe(result.FullName);
            result.Email.ShouldBe(result.Email);
            result.Date.ShouldBe(result.Date);
        }
    }
}
