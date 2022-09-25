using System;
using System.Collections;
using System.Collections.Generic;

namespace _40_239_Linked_list
{
    public class SingleLinkedList<T> : IEnumerable<T>
    {
        private Node<T> _head;
        private Node<T> _tail;

        public SingleLinkedList()
        {
            Count = 0;
            _head = new Node<T>();
            _tail = _head;
        }

        public int Count { get; private set; }

        public void AddLast(T i)
        {
            var n = new Node<T>();
            n.Value = i;

            _tail.Next = n;
            _tail = n;
            Count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var n = _head;

            while (n.Next != null)
            {
                yield return n.Value;
                n = n.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
