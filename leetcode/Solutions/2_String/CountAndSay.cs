using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions._2_String
{
    public class CountAndSay
    {
        public string Solution1(int n)
        {
            string strRet = "1";
            string strTmp = "";
            for (int i = 2; i <=n; i++)
            {
                int cnt = 0;
                for (int j = 0; j < strRet.Length -1; j++)
                {
                    if (strRet[j] == strRet[j+1])
                    {
                        cnt++;
                    }
                    else
                    {
                        cnt++;
                        strTmp += cnt.ToString() + strRet[j];
                        cnt = 0;
                    }
                }
                cnt++;
                strTmp += cnt.ToString() + strRet[strRet.Length -1];
                strRet = strTmp;
                strTmp = "";
            }

            return strRet;

        }
    }
}
