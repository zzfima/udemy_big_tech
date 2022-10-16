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
            var doubly = new DoublyLinkedList<int>();

            doubly.Add(1);
            doubly.Add(2);
            doubly.Add(3);
            doubly.Add(4);
            var cnt = 1;

            foreach (var i in doubly)
            {
                i.Should().Be(cnt);
                cnt++;
            }

            cnt.Should().Be(5);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var doubly = new DoublyLinkedList<int>();

            doubly.Add(2);
            doubly.Add(4);
            doubly.Add(8);
            doubly.Add(16);
            var cnt = 2;

            foreach (var i in doubly)
            {
                i.Should().Be(cnt);
                cnt *= 2;
            }

            cnt.Should().Be(32);
        }
    }
}