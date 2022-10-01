using System.Collections;
using System.Collections.Generic;

namespace _4_31_TypedOutStrings
{
    public class TypedOutStrings
    {
        private const char Backspace = '#';

        public bool IsIdentical(string str1, string str2)
        {
            Stack<char> stack1 = new Stack<char>();
            Stack<char> stack2 = new Stack<char>();

            FillStack(ref stack1, str1);
            FillStack(ref stack2, str2);

            while (stack1.Count != 0)
            {
                var ch1 = stack1.Pop();
                var ch2 = stack2.Pop();

                if (!ch1.Equals(ch2))
                    return false;
            }

            if (stack1.Count != stack2.Count)
                return false;

            return true;
        }

        private void FillStack(ref Stack<char> stack, string str)
        {
            foreach (var ch in str)
            {
                if (ch.Equals(Backspace))
                {
                    stack.Pop();
                    continue;
                }

                stack.Push(ch);
            }
        }
    }
}
