//https://leetcode.com/problems/roman-to-integer/
using System;

namespace _13._Roman_to_Integer
{
    class Program
    {
        public static int RomanToInt(string s)
        {
            int len = s.Length, result = 0;
            if(len == 1)
            {
                return result += Romans(s[0]);
            }
            for (int i = 0; i < len; i++)
            {
                if (i + 1 < len && Romans(s[i]) < Romans(s[i + 1]))
                    result -= Romans(s[i]);
                else
                    result += Romans(s[i]);
            }
            return result;
        }
        public static int Romans(char s)
        {
            switch (s)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    return 0;

            }
        }
            static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("XIV"));
        }
    }
}
