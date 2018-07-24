using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions._5_SortAndSearch
{
    public class BadVersion
    {
        public bool isBadVersion(int version)
        {
            return true;
        }
        public int FirstBadVersion(int n)
        {
            int start = 1;
            int end = n;
            int half = 0;
            while (start < end)
            {
                half = (start + end) / 2;

                if (isBadVersion(half) == true)
                {
                    end = half;
                }
                else
                    start = half;
            }
            return start;
        }
    }
}
