using _40_239_Linked_list;
using FluentAssertions;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var n = new Node<int>() { Value = 44 };

            n.Value.Should().Be(44);
        }
    }
}