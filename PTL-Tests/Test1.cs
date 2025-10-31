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

        [TestMethod]
        public void ClearFilter_DevraitReinitialiserLesAnnees()
        {
            // Arrange
            var service = new DateFilter();
            service.SetDateRange(2015, 2020);

            // Act
            service.ClearFilter();

            // Assert
            Assert.IsNull(service.StartYear);
            Assert.IsNull(service.EndYear);
        }
    }
}
