//https://leetcode.com/problems/longest-common-prefix/
using System;

namespace _14._Longest_Common_Prefix
{
    class Program
    {
        public static string LongestCommonPrefix(string[] strs) 
        {
            if (strs.Length == 0)
                return "";
            string prefix = strs[0];
            for(int i = 1; i < strs.Length; i++)
            {
                while(strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                }
            }
            return prefix;
        }
        static void Main(string[] args)
        {
            string[] arr = { "flower", "fl", "flo" };
            Console.WriteLine(LongestCommonPrefix(arr));
        }
    }
}
