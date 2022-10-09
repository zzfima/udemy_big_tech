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

            while (globalCurrentIndex < str.Length)
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
    }
}
