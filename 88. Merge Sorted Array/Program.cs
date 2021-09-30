//https://leetcode.com/problems/merge-sorted-array/
using System;

namespace _88._Merge_Sorted_Array
{
    class Program
    {
        public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int len = nums1.Length;
            while(m>0 && n> 0)
            {
                if (nums1[m - 1] > nums2[n - 1])
                    nums1[--len] = nums1[--m];
                else
                    nums1[--len] = nums2[--n];
            }
            while(n> 0)
            {
                nums1[--len] = nums2[--n];
            }
            return nums1;
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 0, 0, 0,0 }, arr2 = { 2, 5, 6,86 };
            int m = 3, n = 4;
            Console.WriteLine(string.Join(", ", Merge(arr1,m,arr2,n)));
        }
    }
}
