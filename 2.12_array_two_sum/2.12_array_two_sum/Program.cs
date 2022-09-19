using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2._12_array_two_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ans = TwoSumV1(new[] { 1, 3, 7, 9, 2 }, 11);
            Console.WriteLine(ans != null ? ans[0].ToString() + ", " + ans[1].ToString() : "none");

            ans = TwoSumV2(new[] { 1, 3, 7, 9, 2 }, 11);
            Console.WriteLine(ans != null ? ans[0].ToString() + ", " + ans[1].ToString() : "none");
        }

        static int[] TwoSumV1(int[] nums, int target)
        {
            Console.WriteLine("TwoSumV1 Time complexity = O(n), space complexity = О(n)");

            Dictionary<int, int> numsMap = new Dictionary<int, int>();

            //fill map
            for (int i = 0; i < nums.Length; i++)
            {
                numsMap.Add(nums[i], i);
            }

            //search for nums
            for (int i = 0; i < nums.Length; i++)
            {
                var ntf = NumberToFind(target, nums[i]);
                if (numsMap.Keys.Contains(ntf))
                    return new[] { i, numsMap[ntf] };
            }

            return null;
        }

        static int[] TwoSumV2(int[] nums, int target)
        {
            Console.WriteLine("TwoSumV2 Time complexity = O(n), space complexity = О(n), but it maybe faster than TwoSumV1");

            Dictionary<int, int> numsMap = new Dictionary<int, int>();

            //search for nums
            for (int i = 0; i < nums.Length; i++)
            {
                var ntf = NumberToFind(target, nums[i]);
                if (numsMap.Keys.Contains(ntf))
                    return new[] { i, numsMap[ntf] };
                else
                    numsMap.Add(nums[i], i);
            }

            return null;
        }

        static int NumberToFind(int target, int current) => target - current;
    }
}