//https://leetcode.com/problems/length-of-last-word/
using System;

namespace _58._Length_of_Last_Word
{
    class Program
    {
        public static int LengthOfLastWord(string s)
        {
            int res = 0;
            for(int i = s.Length - 1; i >= 0; i--)
            {
                if (res > 0 && s[i] == ' ')
                    return res;
                if (s[i] != ' ')
                    ++res;

            }
            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLastWord("luffy is the man who will become the pirate king"));
        }
    }
}
