using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinSubArrayLen
{
    class Program
    {
        public static int MinSubArrayLen(int s, int[] nums)
        {
            int sum = 0;
            int start = 0;
            //int end = 0;
            int minLen = Int32.MaxValue;
            for (int end = 0; end < nums.Length; end++)
            {
                sum += nums[end];
                if(sum >= s)
                {
                    minLen = Math.Min(minLen, end - start + 1);
                    while (start <= end&& sum >=s)
                    {
                        minLen = Math.Min(minLen, end - start + 1);
                        sum -= nums[start];
                        start++;
                        
                    }
                    
                }

            }
            if (minLen == Int32.MaxValue)
            {
                return -1;
            }
            return minLen;
        }
        static void Main(string[] args)
        {
            int[] nums = new int[]{ 1,4,4};
            int s = 4;
            int minlen;
            minlen = MinSubArrayLen(s, nums);
            return;
        }
    }
}
