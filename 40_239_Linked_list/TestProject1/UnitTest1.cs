using _40_239_Linked_list;
using FluentAssertions;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NodeShallReturnValue()
        {
            var n = new Node<int>() { Value = 44 };

            n.Value.Should().Be(44);
        }


        [TestMethod]
        public void LinkedListShallBeEmptyWhenStart()
        {
            var s = new SingleLinkedList<int>();
            s.Count.Should().Be(0);
        }

        [TestMethod]
        public void LinkedListShallBe1WhenAdd1()
        {
            var s = new SingleLinkedList<int>();
            s.AddLast(4);
            s.Count.Should().Be(1);
        }

        [TestMethod]
        public void LinkedListShallBe4WhenAdd4()
        {
            var s = new SingleLinkedList<int>();
            s.AddLast(4);
            s.AddLast(5);
            s.AddLast(6);
            s.AddLast(7);
            s.Count.Should().Be(4);
        }
    }
}