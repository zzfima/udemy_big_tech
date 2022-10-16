using System;

namespace Logic
{
    public class MergerDoublyNodes<T>
    {
        public DoublyLinkedList<T> Merge(DoublyNode<T>[] nodes)
        {
            DoublyLinkedList<T> doubly = new DoublyLinkedList<T>();
            DoublyNode<T> head = null;
            DoublyNode<T> tail = null;

            foreach (var doublyNode in nodes)
            {
                if (doublyNode.Previous == null)
                {
                    head = doublyNode;
                }

                if (doublyNode.Next == null)
                {
                    tail = doublyNode;
                }
            }

            if (head == null)
            {
                throw new ArgumentException("no head in list");
            }

            if (tail == null)
            {
                throw new ArgumentException("no tail in list");
            }

            doubly.Count = nodes.Length;
            doubly.Head = head;
            doubly.Tail = tail;

            return doubly;
        }
    }
}
