//https://leetcode.com/problems/maximum-subarray/
using System;

namespace _53._Maximum_Subarray
{
    class Program
    {
        //O(n^2) approach
        //public static int MaxSubArray(int[] nums)
        //{
        //    int result = int.MinValue; 
        //    for(int i = 0; i< nums.Length; i++)
        //    {
        //        int tempSum = 0;
        //        for(int j= i; j < nums.Length; j++)
        //        {
        //            tempSum += nums[j];
        //            if (tempSum > result)
        //                result = tempSum;
        //        }
        //    }
        //    return result;
        //}

        //O(n) approach
        public static int MaxSubArray(int[] nums)
        {
            int result = int.MinValue, tempSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                tempSum += nums[i];
                if (tempSum < nums[i])
                    tempSum = nums[i];
                if (tempSum > result)
                    result = tempSum;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[] nums = { 5, 4, -1, 7, 8 };
            Console.WriteLine(MaxSubArray(nums));
        }
    }
}
