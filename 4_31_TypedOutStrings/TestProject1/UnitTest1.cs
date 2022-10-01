using _4_31_TypedOutStrings;
using FluentAssertions;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var typedOutStrings = new TypedOutStrings();
            typedOutStrings.IsIdentical("aaabbb", "aaabbb").Should().Be(true);

        }

        [TestMethod]
        public void TestMethod2()
        {
            var typedOutStrings = new TypedOutStrings();
            typedOutStrings.IsIdentical("aaabbb1", "aaabbb").Should().Be(false);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var typedOutStrings = new TypedOutStrings();
            typedOutStrings.IsIdentical("aaabbb1#", "aaabbb").Should().Be(true);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var typedOutStrings = new TypedOutStrings();
            typedOutStrings.IsIdentical("aaabbb1#j", "aaabbbj").Should().Be(true);
        }
    }
}