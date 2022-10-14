using System.Collections.Generic;

namespace _6_38_longest_substring
{
    public class LongestSubstringFinder
    {
        /// <summary>
        /// Time O(n^2), space O(n)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int FindLengthBruteForce(string str)
        {
            var globalMaxLength = 0;
            var globalCurrentIndex = 0;
            var localHashSet = new HashSet<char>();

            while (globalCurrentIndex < str.Length - globalMaxLength) // minus globalMaxLength because if left less then MaxCount, no reason to continue
            {
                var localCurrentIndex = globalCurrentIndex;
                var localMaxLength = 0;
                localHashSet.Clear();

                while (localCurrentIndex < str.Length)
                {
                    var c = str[localCurrentIndex];

                    if (localHashSet.Contains(c))
                    {
                        break;
                    }
                    else
                    {
                        localHashSet.Add(c);
                        localMaxLength++;
                    }
                    localCurrentIndex++;
                }

                if (localMaxLength > globalMaxLength)
                    globalMaxLength = localMaxLength;

                globalCurrentIndex++;
            }


            return globalMaxLength;
        }

        /// <summary>
        /// Time O(n), space O(n)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int FindLengthSlidingWindow(string str)
        {
            var maxLength = 0;
            var leftIndex = 0;
            var rightIndex = 0;
            var hash = new Dictionary<char, int>();

            while (leftIndex < str.Length)
            {
                if (leftIndex == rightIndex)
                {
                    hash.Add(str[leftIndex], leftIndex);
                    continue;
                }

                if (!hash.ContainsKey(str[rightIndex]))
                {

                }
            }

            return maxLength;
        }
    }
}
