using Xunit;
using SimpleAPI.Controllers;
using Microsoft.Extensions.Logging;
using Moq;
using System.Linq;

namespace SimpleAPI.Test
{
    public class WeatherForecastControllerTests
    {
        private WeatherForecastController _sut;
        private IMock<ILogger<WeatherForecastController>> _loggerMock;

        public WeatherForecastControllerTests()
        {
            _loggerMock = new Mock<ILogger<WeatherForecastController>>();
            _sut = new WeatherForecastController(_loggerMock.Object);
        }

        [Fact]
        public void Get_ShouldReturnArrayOfFiveRecords_WhenGetCalled()
        {
            var result = _sut.Get();
            Assert.Equal(5, result.Count());
        }
    }
}
