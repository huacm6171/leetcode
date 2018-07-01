using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    public class _541ReverseStr
    {
        public string ReverseStr(string s, int k)
        {
            int iLen = s.Length;
            int curPos = 0;
            string strRet = "";
            while (iLen > 0)
            {
                int i = 0;
                if (iLen > k)
                {
                    for (i = 0; i < k; i++)
                    {
                        strRet += s[curPos + k - 1 - i];
                    }
                    int n = iLen < 2 * k ? iLen : 2 * k;
                    for (; i < n; i++)
                    {
                        strRet += s[curPos + i];
                    }
                    curPos += 2 * k;
                    iLen -= 2 * k;
                }
                else
                {
                    for (i = 0; i < iLen; i++)
                    {
                        strRet += s[curPos + iLen - 1 - i];
                    }
                    iLen = 0;
                }
            }
            return strRet;
        }
    }
}
