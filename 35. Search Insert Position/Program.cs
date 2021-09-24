 //https://leetcode.com/problems/search-insert-position/
using System;

namespace _35._Search_Insert_Position
{
    class Program
    {
        public static int SearchInsert(int[] nums, int target)
        {
            int len = nums.Length;
            if (len == 0)
                return 0;
            for (int i = 0; i < len; ++i)
            {
                if (target == nums[i])
                    return i;
                else if (target < nums[i])
                    return i;
                else if (i == len - 1)
                    return len;
            }
            return 0;
        }
        public static int SearchRecursive(int[] nums, int target, int low, int high)
        {
            if (low > high)
                return low;
            int mid = (low + high) >> 1;
            if (nums[mid] == target)
                return mid;
            if (target < nums[mid])
                return SearchRecursive(nums, target,low, mid -1);
            else if (target > nums[mid])
                return SearchRecursive(nums, target,mid + 1, high);
            else return low;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1,3,5,6 };
            Console.WriteLine(SearchInsert(arr, 7));
            Console.WriteLine(SearchRecursive(arr, 6,0,arr.Length-1));
        }
    }
}
