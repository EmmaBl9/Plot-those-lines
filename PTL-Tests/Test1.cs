using Microsoft.VisualStudio.TestTools.UnitTesting;
using plot_those_lines.Services;

namespace PTL_Tests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void SetDateRange_DevraitDefinirLesAnnees()
        {
            // Arrange
            var service = new DateFilter();

            // Act
            service.SetDateRange(2015, 2020);

            // Assert
            Assert.AreEqual(2015, service.StartYear);
            Assert.AreEqual(2020, service.EndYear);
        }

    }
}
