using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class ContainsDuplicate
    {
        public bool ContainsDuplicateSolution(int[] nums)
        {
            bool bRet = false;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] == nums[i+1])
                {
                    bRet = true;
                    break;
                }
            }
            return bRet;
        }
    }
}
