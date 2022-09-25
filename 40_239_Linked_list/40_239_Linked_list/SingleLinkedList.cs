using System;

namespace _40_239_Linked_list
{
    public class SingleLinkedList<T>
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
            n.Next = _tail;
            _tail = n;
            Count++;
        }
    }
}
