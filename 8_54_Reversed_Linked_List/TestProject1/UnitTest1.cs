using FluentAssertions;
using LinkedList;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var linkedList = new CustomLinkedList<int>();

            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);

            var cnt = 1;

            foreach (var i in linkedList)
            {
                i.Should().Be(cnt);
                cnt++;
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            var linkedList = new CustomLinkedList<int>();

            linkedList.Add(2);
            linkedList.Add(4);
            linkedList.Add(8);
            linkedList.Add(16);

            var cnt = 16;

            var reverser = new EnumerableReverser<int>();
            var reversedLinkedList = reverser.Reverse(linkedList);

            foreach (var i in reversedLinkedList)
            {
                i.Should().Be(cnt);
                cnt /= 2;
            }
        }
    }
}