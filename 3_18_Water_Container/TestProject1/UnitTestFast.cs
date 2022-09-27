using _3_18_Water_Container;
using FluentAssertions;

namespace TestProject1
{
    [TestClass]
    public class UnitTestFast
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
            _optimalWaterContainer.CalculateAreaFast(new[] { 1, 8, 6, 2, 9, 4 })
                .Should()
                .BeEquivalentTo(new WaterContainer() { LeftWallHeigth = 8, RightWallHeigth = 9, Area = 24 });
        }

        [TestMethod]
        public void TestMethod2()
        {
            _optimalWaterContainer.CalculateAreaFast(new[] { 10, 1, 1, 1, 1, 20, 1 })
                .Should()
                .BeEquivalentTo(
                new WaterContainer() { LeftWallHeigth = 10, RightWallHeigth = 20, Area = 50 });

        }

        [TestMethod]
        public void TestMethod3()
        {
            _optimalWaterContainer.CalculateAreaFast(new int[] { })
                .Should()
                .BeEquivalentTo(
                    new WaterContainer() { LeftWallHeigth = 0, RightWallHeigth = 0, Area = 0 });

        }

        [TestMethod]
        public void TestMethod4()
        {
            _optimalWaterContainer.CalculateAreaFast(new int[] { 1 })
                .Should()
                .BeEquivalentTo(
                    new WaterContainer() { LeftWallHeigth = 0, RightWallHeigth = 0, Area = 0 });

        }

        [TestMethod]
        public void TestMethod5()
        {
            _optimalWaterContainer.CalculateAreaFast(new int[] { 1, 1 })
                .Should()
                .BeEquivalentTo(
                    new WaterContainer() { LeftWallHeigth = 1, RightWallHeigth = 1, Area = 1 });

        }
    }
}