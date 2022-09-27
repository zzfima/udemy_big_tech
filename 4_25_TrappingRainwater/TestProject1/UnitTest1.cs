using _4_25_TrappingRainwater;
using FluentAssertions;
using Moq;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodMoq()
        {
            var moq = new Mock<ITrappingWaterCalculator>();
            moq.Setup(m => m.Calculate(It.IsAny<int[]>())).Returns(22);
            moq.Object.Calculate(It.IsAny<int[]>()).Should().Be(22);
        }

        [TestMethod]
        public void TestMethodSlow()
        {
            var calculator = new TrappingWaterCalculator();
            calculator.Calculate(new[] { 0, 1, 0, 2, 1, 0, 3, 1, 0, 1, 2 }).Should().Be(8);
        }
    }
}