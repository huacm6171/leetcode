using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class Intersect
    {
        public int[] IntersectSolve(int[] nums1, int[] nums2)
        {
            List<int> tmpList = new List<int>();
            Array.Sort(nums1);
            Array.Sort(nums2);
            int i, j;
            i = j = 0;
            while (i<nums1.Length && j<nums2.Length)
            {
                if (nums1[i] == nums2[j])
                {
                    tmpList.Add(nums1[i]);
                    i++;j++;
                }
                else if (nums1[i]<nums2[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }
            return tmpList.ToArray();
        }
    }
}
