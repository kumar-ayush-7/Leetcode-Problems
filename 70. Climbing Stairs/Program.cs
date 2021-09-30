//https://leetcode.com/problems/climbing-stairs/
using System;

namespace _70._Climbing_Stairs
{
    class Program
    {
        // Since we know the for any step the maximum number of ways to reach it is the sum of previous two steps
        // we can create a simple solution
        public static int ClimbStairs(int n)
        {
            if (n < 2)
                return n;
            int first = 1, Second = 2, itr = 3;
            while(itr <= n)
            {
                first += Second;
                Second = first - Second;
                first -= Second;
                Second += first;
                ++itr;
            }
            return Second;
        }

        // creating a dp array which will only be valid till no of steps <= 46 
        //static int[] dp = new int[46];
        //public static int ClimbStairs(int n)
        //{

        //    int count = 0;
        //    count += ClimbStair(n);
        //    return count;
        //}

        // using memorization 
        //public static int ClimbStair(int n)
        //{
        //    if (n >= 0)
        //    {
        //        if (dp[n] > 0)
        //            return dp[n];
        //        if (n == 0)
        //            return 1;
        //        else
        //        {
        //            int count = 0;
        //            count += ClimbStair(n - 1);
        //            count += ClimbStair(n - 2);
        //            return dp[n] = count;
        //        }
        //    }
        //    else
        //        return 0;
        //}
        // Simple recursive method
        //public static int ClimbStair(int n)
        //{
        //    if (n >= 0)
        //    {
        //        if (n == 0)
        //            return 1;
        //        else
        //        {
        //            int count = 0;
        //            count += ClimbStair(n - 1);
        //            count += ClimbStair(n - 2);
        //            return count;
        //        }
        //    }
        //    else
        //        return 0;
        //}
        static void Main(string[] args)
        {
            Console.WriteLine(ClimbStairs(5));
        }
    }
}
