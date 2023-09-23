using Moq;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProductionCode.App.Unit.Tests
{
    public class DeliveryServiceTests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void Can_detect_an_invalid_delivery_date(
            DateTime deliveryDate,
            bool expected)
        {
            /* ... */
        }
        public static List<object[]> Data()
        {
            return new List<object[]>
            {
                new object[] { DateTime.Now.AddDays(-1), false },
                new object[] { DateTime.Now, false },
                new object[] { DateTime.Now.AddDays(1), false },
                new object[] { DateTime.Now.AddDays(2), true }
            };
        }

        [Fact]
        public void Sending_a_greetings_email()
        {
            var mock = new Mock<IEmailGateway>();
            var sut = new Controller(mock.Object);

            sut.GreetUser("user@email.com");

            mock.Verify(x => x.SendGreetingsEmail("user@email.com"), Times.Once);
        }

        [Fact]
        public void Creating_a_report()
        {
            var stub = new Mock<IDatabase>();
            stub.Setup(x => x.GetNumberOfUsers()).Returns(10);

            var sut = new Controller(stub.Object);

            Report report = sut.CreateReport();
            Assert.Equal(10, report.NumberOfUsers);
        }

        // Consistent
        [Fact]
        public void Consistent()
        {
            var currenDate = DateTime.Now;
            var value = Random.Shared.Next();
        }

        [Fact]
        public void Can_make_reservation()
        {
            // Arrange
            // Act
            // Assert
        }
        [Fact]
        public void Total_bill_equals_sum_of_menu_item_price()
        {
            // Arrange
            // Act
            // Assert
        }

        bool before, after;
        bool result1, result2, result3;

        [Fact]
        public void Test_before_or_after()
        {
            if (before)
            {
                Assert.True(result1);
            }
            else if (after)
            {
                Assert.True(result2);
            }
            else
            {
                Assert.True(result3);
            }
        }

        [Fact]
        public void Test_before()
        {
            Assert.True(result1);
        }

        [Fact]
        public void Test_after()
        {
            Assert.True(result1);
        }

        [Fact]
        public void Test_now()
        {
            Assert.True(result1);
        }

        [Fact]
        public void Error_if_reading_before_initialized_capture_exdemo()
        {
            var sut = new TemperatureSensor();

            var ex = Assert.Throws<InvalidOperationException>(() => sut.ReadCurrentTemperature());

            Assert.Equal("Cannot read temperature before initializing.", ex.Message);
        }
    }

    public class TemperatureSensor
    {
        public void ReadCurrentTemperature() { }
    }
}
