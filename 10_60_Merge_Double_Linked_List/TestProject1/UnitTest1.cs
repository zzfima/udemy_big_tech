using FluentAssertions;
using Logic;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodDoublyLinkedList1()
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
        public void TestMethodDoublyLinkedList2()
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

        [TestMethod]
        public void ShallFailNoHead()
        {
            DoublyNode<int> node1 = new DoublyNode<int>() { Value = 11 };
            DoublyNode<int> node2 = new DoublyNode<int>() { Value = 12 };

            node1.Next = node2;
            node1.Previous = node2;
            node2.Previous = node1;
            node2.Next = null;
            
            var nodes = new DoublyNode<int>[]
            {
                node2, node1
            };

            var merger = new MergerDoublyNodes<int>();
            Action act = () => merger.Merge(nodes);
            act.Should().Throw<ArgumentException>().WithMessage("no head in list");
        }

        [TestMethod]
        public void ShallFailNoTail()
        {
            DoublyNode<int> node1 = new DoublyNode<int>() { Value = 11 };
            DoublyNode<int> node2 = new DoublyNode<int>() { Value = 12 };

            node1.Next = node2;
            node1.Previous = null;
            node2.Previous = node1;
            node2.Next = node1;

            var nodes = new DoublyNode<int>[]
            {
                node2, node1
            };

            var merger = new MergerDoublyNodes<int>();
            Action act = () => merger.Merge(nodes);
            act.Should().Throw<ArgumentException>().WithMessage("no tail in list");
        }


        [TestMethod]
        public void TestMethod5()
        {
            DoublyNode<int> node1 = new DoublyNode<int>() { Value = 11 };
            DoublyNode<int> node2 = new DoublyNode<int>() { Value = 12 };
            DoublyNode<int> node3 = new DoublyNode<int>() { Value = 13 };
            DoublyNode<int> node4 = new DoublyNode<int>() { Value = 14 };
            DoublyNode<int> node5 = new DoublyNode<int>() { Value = 15 };

            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;

            node5.Previous = node4;
            node4.Previous = node3;
            node3.Previous = node2;
            node2.Previous = node1;

            var nodes = new DoublyNode<int>[]
            {
                node2, node1, node3, node5, node4
            };

            var merger = new MergerDoublyNodes<int>();
            var doubly = merger.Merge(nodes);
            var cnt = 11;

            foreach (var i in doubly)
            {
                i.Should().Be(cnt);
                cnt += 1;
            }

            cnt.Should().Be(16);
        }
    }
}