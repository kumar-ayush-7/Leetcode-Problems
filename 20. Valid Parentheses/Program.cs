// https://leetcode.com/problems/valid-parentheses/
using System;
using System.Collections.Generic;

namespace _20._Valid_Parentheses
{
    class Program
    {
        public static bool IsValid(string s)
        {
            Stack<string> st = new Stack<string>();
            for (int i = 0; i < s.Length; i++)
            {
                string item = s[i].ToString();
                if (item == "(" || item == "{" || item == "[")
                {
                    st.Push(item);
                }
                if (item == ")" || item == "}" || item == "]")
                {
                    if (st.Count > 0)
                    {
                        string top = st.Pop();
                        //if ((item == ")" && top != "(") || (item == "]" 
                        //    && top != "[") || (item == "}" && top != "{"))
                        switch (item)
                        {
                            case ")":
                                {
                                    if (top != "(")
                                        return false;
                                    break;
                                }
                            case "]":
                                {
                                    if (top != "[")
                                        return false;
                                    break;
                                }
                            case "}":
                                {
                                    if (top != "{")
                                        return false;
                                    break;
                                }

                        }
                    }
                    else
                        return false;
                }
            }
            if (st.Count > 0)
                return false;
            else
                return true;
        }
        static void Main(string[] args)
        {
            string input = "(}";
            Console.WriteLine(IsValid(input));
        }
    }
}
