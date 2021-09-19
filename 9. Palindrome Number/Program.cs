//https://leetcode.com/problems/palindrome-number/
using System;

namespace _9._Palindrome_Number
{
    class Program
    {
        public static bool IsPalindrome(int x)
        {
            if (x >= 0 && x < 10)
                return true;
            else if (x < 0)
                return false;
            else
            {
                int reverse = 0, temp = x;
                while (temp != 0)
                {
                    reverse *= 10;
                    reverse += temp % 10;
                    temp = temp / 10;
                }
                if (x != reverse)
                    return false;
            }
            return true;

        }
        static void Main(string[] args)
        {
            int input = 5115;
            Console.WriteLine(IsPalindrome(input));
        }
    }
}
