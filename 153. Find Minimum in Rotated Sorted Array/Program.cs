//https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
using System;

namespace _153._Find_Minimum_in_Rotated_Sorted_Array
{
    class Program
    {
        public static int FindMin(int[] nums)
        {
            int high = nums.Length - 1, low = 0;
            while (high > low)
            {
                int mid = low + (high - low) / 2;
                if (nums[mid] < nums[high])
                    high = mid;
                else
                    low = mid + 1;
            }
            return nums[low];
        }
        static void Main(string[] args)
        {
            int[] nums = { 3, 4, 5, 1, 2 };
            Console.WriteLine(FindMin(nums));
        }
    }
}
