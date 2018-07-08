using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class TwoSum
    {
        //时间复杂度过高
        public int[] SolutionOne(int[] nums, int target)
        {
            List<int> listRet = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        listRet.Add(i);
                        listRet.Add(j);
                        break;
                    }
                }

            }
            return listRet.ToArray();
        }
    }
}
