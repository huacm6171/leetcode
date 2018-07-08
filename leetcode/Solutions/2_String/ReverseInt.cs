
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class ReverseInt
    {
        public int Solution1(int x)
        {
            int retVal = 0;
            while (x !=0)
            {
                if (Math.Abs(retVal) > Int32.MaxValue/10)
                {
                    return 0;
                }
                retVal = retVal * 10 + x % 10;
                x = x / 10;
            }  
            return retVal;
        }
    }
}
