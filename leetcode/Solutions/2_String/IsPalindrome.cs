using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class IsPalindrome
    {
        public bool Solution1(string s)
        {
            bool bRet = true;
            int i, j;
            i = 0;
            j = s.Length - 1;
            s = s.ToLower();
            while (i < j)
            {
                while (!Char.IsLetterOrDigit(s[i]))
                {
                    i++;
                    if (i>j)
                    {
                        return true;
                    }
                }
 
                while (!Char.IsLetterOrDigit(s[j]))
                    j--;

                if (s[i] == s[j])
                {
                    i++;
                    j--;
                }
                else
                {
                    bRet = false;
                    break;
                }
                    
            }

            return bRet;
        }
    }
}
