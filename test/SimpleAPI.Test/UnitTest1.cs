using System;
using Xunit;
using SimpleAPI.Controllers;
using System.Collections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace SimpleAPI.Test
{
    public class UnitTest1
    {
         public static ILogger<WeatherForecastController> _logger;
        WeatherForecastController controller = new WeatherForecastController(_logger);
        [Fact]
        public void GetReturnsMyname()
        {
            IEnumerable returnValue = controller.Get();
            Assert.Equal("Subbu21","Subbu21");
        }


        [Fact]
        public void Test1()
        {

        }
    }
}
