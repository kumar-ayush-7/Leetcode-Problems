//https://leetcode.com/problems/plus-one/
using System;
using System.Collections.Generic;

namespace _66._Plus_One
{
    class Program
    {
        public static int[] PlusOne(int[] digits)
        {
            Stack<int> res = new Stack<int>();
            int carry = 0, item = 0, len = digits.Length;
            ++digits[len - 1];
            for (int i = len - 1; i >= 0; i--)
            {
                item = digits[i] + carry;
                if (item > 9)
                {
                    item = item % 10;
                    carry = 1;
                }
                else
                    carry = 0;
                res.Push(item);
            }
            if (carry > 0)
                res.Push(carry);
            return res.ToArray();
        }
        static void Main(string[] args)
        {
            int[] arr = { 4, 3, 2, 1 };
            Console.WriteLine($"{string.Join(", ", PlusOne(arr))}");
        }
    }
}
