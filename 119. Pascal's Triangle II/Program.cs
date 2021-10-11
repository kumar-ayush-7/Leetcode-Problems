//https://leetcode.com/problems/pascals-triangle-ii/
using System;
using System.Collections.Generic;

namespace _119._Pascal_s_Triangle_II
{
    class Program
    {
        public static IList<int> GetRow(int rowIndex)
        {
            IList<IList<int>> pas = new List<IList<int>>();
            IList<int> first = new List<int>();
            first.Add(1);
            pas.Add(first);
            for (int i = 1; i < rowIndex + 1; i++)
            {
                IList<int> item = new List<int>();
                IList<int> prev = pas[i - 1];
                item.Add(1);
                for (int j = 1; j < i; j++)
                {
                    item.Add(prev[j - 1] + prev[j]);
                }
                item.Add(1);
                pas.Add(item);
            }
            return pas[rowIndex];
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
