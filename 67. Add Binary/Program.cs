//https://leetcode.com/problems/add-binary/
using System;
using System.Text;

namespace _67._Add_Binary
{
    class Program
    {
        public static string AddBinary(string a, string b)
        {
            StringBuilder sb = new StringBuilder();
            int i = a.Length - 1, j = b.Length - 1, carry = 0;
            while (i >= 0 || j >= 0)
            {
                int sum = carry;
                if (j >= 0) sum += b[j--] - '0';
                if (i >= 0) sum += a[i--] - '0';
                sb.Append(sum % 2);
                carry = sum / 2;
            }
            if (carry != 0) sb.Append(carry);
            string result = "";
            for (int k = sb.Length - 1; k >= 0; k--)
                result += sb[k].ToString();
            return result;
        }
        //public static string AddBinary(string a, string b)
        //{
        //    int i = a.Length - 1, j = b.Length - 1, carry = 0;
        //    string res = "";
        //    while (i >= 0 && j >= 0)
        //    {
        //        if (a[i] != b[j])
        //        {
        //            if (carry != 0)
        //            {
        //                res += "0";
        //                carry = 1;
        //            }
        //            else
        //            {
        //                res += "1";
        //            }
        //        }
        //        else if (a[i] == '1' && b[j] == '1')
        //        {
        //            if (carry != 0)
        //            {
        //                res += "1";
        //            }
        //            else
        //            {
        //                res += "0";
        //            }
        //            carry = 1;
        //        }
        //        else
        //        {
        //            if (carry != 0)
        //            {
        //                res += "1";
        //                carry = 0;
        //            }
        //            else
        //                res += 0;
        //        }
        //        i--;
        //        j--;
        //    }
        //    while (i >= 0)
        //    {
        //        if (a[i] == '0')
        //        {
        //            if (carry != 0)
        //            {
        //                res += "1";
        //                carry = 0;
        //            }
        //            else
        //            {
        //                res += "0";
        //            }
        //        }
        //        else
        //        {
        //            if (carry != 0)
        //            {
        //                res += "0";
        //                carry = 1;
        //            }
        //            else
        //            {
        //                res += "1";
        //            }
        //        }
        //        i--;
        //    }
        //    while (j >= 0)
        //    {
        //        if (b[j] == '0')
        //        {
        //            if (carry != 0)
        //            {
        //                res += "1";
        //                carry = 0;
        //            }
        //            else
        //            {
        //                res += "0";
        //            }
        //        }
        //        else
        //        {
        //            if (carry != 0)
        //            {
        //                res += "0";
        //                carry = 1;
        //            }
        //            else
        //            {
        //                res += "1";
        //            }
        //        }
        //        j--;
        //    }
        //    if (carry != 0)
        //        res += "1";
        //    string result = "";
        //    for (int k = res.Length - 1; k >= 0; k--)
        //        result += res[k].ToString();
        //    return result;
        //}
        static void Main(string[] args)
        {
            Console.WriteLine(AddBinary("110010", "10111"));
        }
    }
}