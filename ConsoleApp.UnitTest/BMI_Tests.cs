using Microsoft.VisualStudio.TestTools.UnitTesting;
using CO453_ConsoleAppAnswer.App02;

namespace ConsoleApp.UnitTest
{
    [TestClass]
    public class BMI_Tests
    {

        private BMI calculator = new BMI();

        [TestMethod]
        public void TestHighestUnderweight()
        {
            // Arrange
            double expectedBMI = 18;

            // Act

            double actualBMI = calculator.CalculateMetricBMI();

            // Assert

            Assert.AreEqual(expectedBMI, actualBMI);
        }
    }
}
