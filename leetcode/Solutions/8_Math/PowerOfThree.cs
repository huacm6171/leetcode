using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions._8_Math
{
    public class PowerOfThree
    {
        public bool IsPowerOfThree(int n)
        {
            if (n <= 0)
                return false;

            int iMax = (int)(Math.Log10(int.MaxValue) / Math.Log10(3));
            iMax = (int)Math.Pow(3, iMax);
            if (iMax % n == 0)
                return true;
            else
                return false;
        }
    }
}
