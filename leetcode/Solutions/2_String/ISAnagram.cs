using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class ISAnagram
    {
        public bool Solution1(string s, string t)
        {
            if (s.Length != t.Length)
                return false;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                    dict[s[i]]++;
                else
                    dict.Add(s[i], 1);
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (dict.ContainsKey(t[i]))
                {
                    dict[t[i]]--;
                }
                else
                    return false;
            }
            foreach (int val in dict.Values)
            {
                if (val != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
