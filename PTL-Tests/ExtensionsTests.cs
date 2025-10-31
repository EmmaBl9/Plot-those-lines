using Microsoft.VisualStudio.TestTools.UnitTesting;
using plot_those_lines.Services;


namespace PTL_Tests
{
    [TestClass]
    public sealed class ExtensionsTests
    {
        [TestMethod]
        public void RoundTo2_DevraitArrondir_NombrePositif()
        {
            // Arrange
            decimal? value = 123.456m;

            // Act
            var result = value.RoundTo2();

            // Assert
            Assert.AreEqual(123.46m, result);
        }

        [TestMethod]
        public void RoundTo2_DevraitArrondir_NombreNegatif()
        {
            // Arrange
            decimal? value = -123.456m;

            // Act
            var result = value.RoundTo2();

            // Assert
            Assert.AreEqual(-123.46m, result);
        }

        [TestMethod]
        public void IsEmpty_DevraitRetournerVrai_PourListeVide()
        {
            // Arrange
            var list = new List<int>();

            // Act
            var result = list.IsEmpty();

            // Assert
            Assert.IsTrue(result);
        }
    }
}