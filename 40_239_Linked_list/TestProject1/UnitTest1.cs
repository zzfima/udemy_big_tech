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
        public void LinkedListShallBe1WhenAddToBack1()
        {
            var s = new SingleLinkedList<int>();
            s.AddLast(4);
            s.Count.Should().Be(1);
        }

        [TestMethod]
        public void LinkedListShallBe4WhenAddToBack4()
        {
            var s = new SingleLinkedList<int>();
            s.AddLast(4);
            s.AddLast(5);
            s.AddLast(6);
            s.AddLast(7);
            s.Count.Should().Be(4);
        }


        [TestMethod]
        public void LinkedListShallInsert()
        {
            var s = new SingleLinkedList<int>();
            s.AddLast(4);
            s.AddLast(5);
            s.AddLast(7);
            s.AddLast(8);
            s.Insert(2, 6);
            int check = 4;

            foreach (var i in s)
            {
                i.Should().Be(check);
                check ++;
            }
        }

        [TestMethod]
        public void LinkedListDoForEach()
        {
            var s = new SingleLinkedList<int>();
            s.AddLast(6);
            s.AddLast(9);
            s.AddLast(12);
            s.AddLast(15);
            s.AddStart(3);
            s.AddStart(0);

            int check = 0;

            foreach (var i in s)
            {
                i.Should().Be(check);
                check += 3;
            }
        }
    }
}