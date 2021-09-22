// https://leetcode.com/problems/remove-element/
using System;

namespace _27._Remove_Element
{
    class Program
    {
        public static int RemoveElement(int[] nums, int val)
        {
            int len = nums.Length;
            if (len == 0) return len;
            int j = 0;
            for(int i =0; i< len; ++i)
            {
                if (nums[i] != val)
                    nums[j++] = nums[i];
            }
            return j;
            
        }
        static void Main(string[] args)
        {
            int[] arr = {3,3};
            int val = 3;

            Console.WriteLine(RemoveElement(arr,val));
        }
    }
}
