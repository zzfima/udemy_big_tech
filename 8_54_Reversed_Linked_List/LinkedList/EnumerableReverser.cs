using System.Collections.Generic;

namespace LinkedList
{
    public class EnumerableReverser<T>
    {
        public IEnumerable<T> Reverse(IEnumerable<T> collection)
        {
            var reversedLinkedList = new CustomLinkedList<T>();
            var stack = new Stack<T>();

            foreach (var v in collection)
            {
                stack.Push(v);
            }

            while (stack.Count > 0)
            {
                reversedLinkedList.Add(stack.Pop());
            }

            return reversedLinkedList;
        }
    }
}
