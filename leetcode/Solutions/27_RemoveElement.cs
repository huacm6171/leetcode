using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class _27_RemoveElement
    {
        public int RemoveElement(int[] nums, int val)
        {
            int cnt = 0;
            int i = 0, j = nums.Length;
            while(i < j)
            {
                if (nums[i] != val)
                    i++;
                if (nums[j - 1] == val)
                {
                    j--;
                    cnt++;
                }

                if (i<j && nums[i] == val && nums[j-1]!= val)
                {
                    nums[i] = nums[j - 1];
                    i++;
                    j--;
                    cnt++;
                }
            }
            return nums.Length - cnt;
        }
    }
}
