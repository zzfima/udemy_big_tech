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
            var newNode = new Node<T>();
            newNode.Value = i;

            _tail.Next = newNode;
            _tail = newNode;
            Count++;
        }

        public void AddStart(T i)
        {
            var newNode = new Node<T>();
            newNode.Value = i;

            newNode.Next = _head.Next;
            _head.Next = newNode;

            Count++;
        }

        public void Insert(int index, T i)
        {
            int cnt = 0;

            Node<T> current = _head;

            while (current != null)
            {

                if (cnt == index)
                {
                    var newNode = new Node<T>();
                    newNode.Value = i;

                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }

                current = current.Next;
                cnt++;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var n = _head.Next;

            while (n != null)
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
