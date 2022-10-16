using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        public DoublyNode<T> Head { get; set; }
        public DoublyNode<T> Tail { get; set; }
        public int Count { get; set; }

        public DoublyLinkedList()
        {
            Count = 0;
        }

        public void Add(T value)
        {
            var newNode = new DoublyNode<T>() { Value = value };

            if (Count == 0)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                newNode.Previous = Tail;
                Tail.Next = newNode;
                Tail = newNode;
            }

            Count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentNode = Head;

            while (currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
