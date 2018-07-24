using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions._5_SortAndSearch
{
    public class MergeArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int mergeLen;
            mergeLen = m + n;

            while (m > 0 && n>0)
            {
                if (nums1[m-1] > nums2[n-1])
                {
                    nums1[mergeLen - 1] = nums1[m - 1];
                    m--;
                }
                else
                {
                    nums1[mergeLen - 1] = nums2[n - 1];
                    n--;
                }
                mergeLen --;
            }
            while (n>0)
            {
                nums1[mergeLen - 1] = nums2[n - 1];
                n--;
                mergeLen--;
            }
        }
    }
}
