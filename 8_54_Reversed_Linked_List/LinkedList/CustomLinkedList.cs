using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedList
{
    public class CustomLinkedList<T> : IEnumerable<T>
    {
        private Node<T> _head;
        private Node<T> _tail;
        int _count;

        public CustomLinkedList()
        {
            _head = new Node<T>();
            _tail = _head;
            _count = 0;
        }

        public void Add(T value)
        {
            var newNode = new Node<T>() { Value = value };
            if (_count == 0)
            {
                _head = newNode;
                _head.Next = _tail;
                _tail = newNode;
            }
            else
            {
                _tail.Next = newNode;
                _tail = newNode;
            }

            _count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = _head;
            do
            {
                yield return current.Value;
                current = current.Next;
            } while (current.Next != null);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
