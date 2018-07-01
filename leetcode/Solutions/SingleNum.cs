using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class SingleNum
    {
        public int SingleNumber(int []nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    return nums[i];
                }
                else
                    i++;
            }
            return nums[nums.Length - 1];
        }
        public int SingleNumberSolve2(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict.Remove(nums[i]);
                }
                else
                {
                    dict.Add(nums[i], 1);
                }
            }
            return dict.Keys.ToArray()[0];
        }
    }
}
