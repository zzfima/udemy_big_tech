using _3_18_Water_Container;
using FluentAssertions;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private static OptimalWaterContainer _optimalWaterContainer;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            _optimalWaterContainer = new OptimalWaterContainer();
        }

        [TestMethod]
        public void TestMethod1()
        {
            _optimalWaterContainer.CalculateAreaSlow(new[] { 1, 8, 6, 2, 9, 4 })
                .Should()
                .BeEquivalentTo(new WaterContainer() { LeftWall = 8, RightWall = 9, Area = 24 });
        }

        [TestMethod]
        public void TestMethod2()
        {
            _optimalWaterContainer.CalculateAreaSlow(new[] { 10, 1, 1, 1, 1, 20, 1 })
                .Should()
                .BeEquivalentTo(
                new WaterContainer() { LeftWall = 10, RightWall = 20, Area = 50 });

        }
    }
}