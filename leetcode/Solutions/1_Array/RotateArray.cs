using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class RotateArray
    {
        //空间换时间
        public void SolutionsOne(int[] nums, int k)
        {
            int len = nums.Length;
            int[] tmpNums = new int[len];
            for (int i = 0; i < len; i++)
            {
                tmpNums[(i + k) % len] = nums[i];
            }
            for (int i = 0; i < len; i++)
            {
                nums[i] = tmpNums[i];
            }
        }
    }
}
