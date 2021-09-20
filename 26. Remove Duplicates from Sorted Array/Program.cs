// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
using System;

namespace _26._Remove_Duplicates_from_Sorted_Array
{
    class Program
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return 1;
            int i = 1, j = 1;
            while(i< nums.Length)
            {
                if (nums[i - 1] < nums[i])
                {
                    nums[j++] = nums[i];
                }
                i++;
            }
            return j;
        }
        static void Main(string[] args)
        {
            int[] arr = {0, 0, 1, 1, 1, 2, 2, 3, 3, 4};

            Console.WriteLine(RemoveDuplicates(arr));
        }
    }
}
