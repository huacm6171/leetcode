using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class FirstUniqChar
    {
        public int Solution1(string s)
        {
            if (s=="")
            {
                return -1;
            }
            List<char> lExists = new List<char>();
            for (int i = 0; i < s.Length-1; i++)
            {
                if (lExists.Contains(s[i]))
                {
                    continue;
                }
                int n = s.Substring(i + 1).IndexOf(s[i]);
                if (n == -1)
                {
                    return i;
                }
                else
                    lExists.Add(s[i]);
                
            }
            if (!lExists.Contains(s[s.Length-1]))
            {
                return s.Length - 1;
            }
            return -1;
        }
    }
}
