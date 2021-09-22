//https://leetcode.com/problems/implement-strstr/
using System;

namespace _28._Implement_strStr__
{
    class Program
    {
        public static int StrStr(string haystack, string needle)
        {
            int hayLen = haystack.Length, neeLen = needle.Length;
            if (needle == "")
                return 0;
            else if (neeLen > hayLen)
                return -1;
            else
            {
                for( int i=0; i<=hayLen-neeLen; ++i)
                {
                    string tmp = haystack.Substring(i, neeLen);
                    if (tmp == needle)
                        return i;
                }
                return -1;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(StrStr("a","a"));
        }
    }
}
