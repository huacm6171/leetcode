using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions._8_Math
{
    public class CountPrimes
    {
        public bool bPrimes(int n)
        {
            bool bRet = true;
            if (n == 1)
            {
                return false;
            }
            if (n==2)
            {
                return true;
            }
            int sqrt = (int)Math.Floor( Math.Sqrt(n));
            for (int i = 2; i <= sqrt; i++)
            {
                if (n%i == 0)
                {
                    bRet = false;
                    break;
                }
            }
            return bRet;
        }

        public int MyCountPrimes(int n)
        {
            int cnt = 0;
            for (int i = 1; i <n; i++)
            {
                if (bPrimes(i))
                {
                    cnt++;
                }
            }
            return cnt;
        }
    }
}
