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
        private DoublyNode<T> _head;
        private DoublyNode<T> _tail;
        private int _count;

        public DoublyLinkedList()
        {
            _count = 0;
        }

        public void Add(T value)
        {
            var newNode = new DoublyNode<T>() { Value = value };

            if (_count == 0)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                newNode.Previous = _tail;
                _tail.Next = newNode;
                _tail = newNode;
            }

            _count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentNode = _head;

            while (currentNode!= null)
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
