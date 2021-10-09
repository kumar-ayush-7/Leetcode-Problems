//https://leetcode.com/problems/find-minimum-in-rotated-sorted-array-ii/
using System;

namespace _154._Find_Minimum_in_Rotated_Sorted_Array_II
{
    class Program
    {
        public static int FindMin(int[] nums)
        {
            int high = nums.Length - 1, low = 0;
            while (high > low)
            {
                int mid = low + (high - low) / 2;
                if (nums[mid] == nums[high])
                    high = high - 1;
                else
                {

                    if (nums[mid] < nums[high])
                        high = mid;
                    else
                        low = mid + 1;
                }
            }
            return nums[low];
        }
        static void Main(string[] args)
        {
            int[] nums = { 2, 2, 2, 0, 1 };
            Console.WriteLine(FindMin(nums));
        }
    }
}
