using FluentAssertions;
using Logic;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var checker = new PalindromeChecker();
            checker.Check("aba").Should().BeTrue();
            checker.Check("abc").Should().BeFalse();
            checker.Check("abA").Should().BeTrue();
            checker.Check("ab A").Should().BeTrue();
            checker.Check("redivider, deified, civic, radar, level, rotor, kayak, reviver, racecar, madam, and refer").Should().BeFalse();
            checker.Check("Was it a car or a cat I saw?").Should().BeTrue();
            checker.Check("Live on time, emit no evil").Should().BeTrue();
        }
    }
}