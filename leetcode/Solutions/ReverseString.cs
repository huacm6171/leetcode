using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class ReverseString
    {
        public string Solution1(string s)
        {
            int n = s.Length;
            char[] ch = s.ToCharArray();
            char tmp;
            for (int i = 0; i < n/2; i++)
            {
                tmp = ch[i];
                ch[i] = ch[n - i - 1];
                ch[n - i - 1] = tmp;
            }
            return new string(ch);
        }
    }
}
