using _6_38_longest_substring;
using FluentAssertions;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var s1 = "abcbbd";
            var substringFinder = new LongestSubstringFinder();
            substringFinder.FindLengthBruteForce(s1).Should().Be(3); //abc = 3
            substringFinder.FindLengthSlidingWindow(s1).Should().Be(3);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var s1 = "abcbdca";
            var substringFinder = new LongestSubstringFinder();
            substringFinder.FindLengthBruteForce(s1).Should().Be(4); //bdca  = 4
            substringFinder.FindLengthSlidingWindow(s1).Should().Be(4);
        }
    }
}