//https://leetcode.com/problems/sqrtx/
using System;

namespace _69._Sqrt_x_
{
    class Program
    {
        public static int MySqrt(int x)
        {
            if (x < 2)
                return x;
            else
            {
                int low = 1, high = x;
                while(low < high)
                {
                    int mid = low + (high - low)/2;
                    if (mid == x/mid)
                        return mid;
                    else if (mid > x/mid)
                        high = mid;
                    else
                        low = mid + 1;
                }
                return low - 1;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MySqrt(2147395598));
        }
    }
}
