using EnsekSolution.WebApi.Controllers;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace EnsekSolution.UnitTesting.Controllers
{
    [TestClass]
    public class MeterReadingControllerTests
    {
        private MeterReadingController _meterReadingController;
        private readonly Mock<ILogger<MeterReadingController>> _logger = new Mock<ILogger<MeterReadingController>>();

        public MeterReadingControllerTests()
        {
        }
    }
}
