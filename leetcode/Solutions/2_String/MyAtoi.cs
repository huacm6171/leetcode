using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class MyAtoi
    {
        public int Solution1(string s)
        {
            s = s.Trim();

            if (s=="")
            {
                return 0;
            }
            bool bPositive = true;

            if ((s[0] == '+' || s[0] == '-') && s.Length > 1)
            {
                if (!Char.IsDigit(s[1]))
                {
                    return 0;
                }
                else if (s[0] == '-')
                {
                    bPositive = false;
                }
            }
            else if (!Char.IsDigit(s[0]) && s[0] != '+')
            {
                return 0;
            }
            int retVal = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (!Char.IsDigit(s[i]) && i!=0)
                {
                    break ;
                }
                if (Char.IsDigit(s[i]))
                {
                    if (retVal > Int32.MaxValue/10 || retVal > 10*(Int32.MaxValue / 10))
                    {
                        retVal = bPositive ? Int32.MaxValue : Int32.MinValue;
                        break;
                    }
                    else if(retVal == Int32.MaxValue/10 && s[i]>'7')
                    {
                        retVal = bPositive ? Int32.MaxValue : Int32.MinValue;
                        break;
                    }
                    retVal = retVal * 10 + s[i] - '0';
                }
            }
            retVal = bPositive ? retVal : 0 - retVal;
            return retVal;
        }
    }
}
