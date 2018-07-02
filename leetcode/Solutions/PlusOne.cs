using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class PlusOne
    {
        public int[] PlusOneSolve(int[] digits)
        {
            List<int> tmpList = new List<int>();
            int n = digits.Length;
            bool bCarry = true;
            while (n>0)
            {
                if (bCarry)
                {
                    if ((digits[n - 1] + 1) / 10 > 0)
                        bCarry = true;
                    else
                        bCarry = false;
                    tmpList.Insert(0, (digits[n - 1] + 1) % 10);
                }
                else
                    tmpList.Insert(0, digits[n - 1]);
                n--;
            }
            if (bCarry)
            {
                tmpList.Insert(0, 1);
            }
            return tmpList.ToArray();
        }
    }
}
