using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions._6_Dynamic
{
    public class ClimbStairs
    {
        public int CalClimbStairs(int n)
        {
            int[] res = new int[n];
            if (n >= 1) res[0] = 1;
            if (n >= 2) res[1] = 2;

            for (int i = 2; i < n; i++)
            {
                res[i] = res[i-1] + res[i - 2];
            }
            return res[n- 1];
        }
    }
}
