using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SandBoxAPI.Controllers;
using System.Linq;
using Xunit;

namespace TestAPI
{
    [TestClass]
    public class WeatherTest
    {
        [TestMethod]
        public void GetAllWeathers()
        {
            var _mockLogger = new Mock<ILogger<WeatherForecastController>>();
            var weatherController = new WeatherForecastController(_mockLogger.Object);
            var result = weatherController.Get("Header Teste", new SandBoxAPI.Models.BodyModel { Key = "Teste"});

            Assert.IsTrue(result.IsStatusCodeSuccess && result.data.Any());
        }
    }
}
