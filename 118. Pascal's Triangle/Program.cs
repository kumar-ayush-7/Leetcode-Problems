//https://leetcode.com/problems/pascals-triangle/
using System;
using System.Collections.Generic;

namespace _118._Pascal_s_Triangle
{
    class Program
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> res = new List<IList<int>>();
            if (numRows == 0)
                return res;
            List<int> row1 = new List<int>();
            row1.Add(1);
            res.Add(row1);
            for (int i = 1; i < numRows; i++)
            {
                IList<int> prev = res[i - 1];
                IList<int> item = new List<int>();
                item.Add(1);
                for (int j = 1; j < i; j++)
                {
                    item.Add(prev[j] + prev[j - 1]);
                }
                item.Add(1);
                res.Add(item);
            }
            return res;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
