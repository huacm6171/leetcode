using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPairSum_561
{
    public class Solution
    {
        public int ArrayPairSum(int[] nums)
        {
            int iSum = 0;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i+=2)
            {
                iSum += nums[i];
            }
            return iSum;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
        }
    }
}
