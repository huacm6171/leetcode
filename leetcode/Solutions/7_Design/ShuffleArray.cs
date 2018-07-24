using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions._7_Design
{
    public class ShuffleArray
    {
        public int[] _nums;
        public Random rd = new Random();
        public void Solution(int[] nums)
        {
            _nums = nums;
        }
        public int[] Reset()
        {
            return _nums;
        }

        public int[] Shuffle()
        {
            int[] resArray = new int[_nums.Length];
            int[] flag = new int[_nums.Length];
            for (int i = 0; i < _nums.Length; i++)
            {
                flag[i] = 0;
            }
            int n = 0;
            
            int len = _nums.Length;
            for (int i = 0; i < len; i++)
            {
                
                while (true)
                {
                    n = rd.Next(0,len);
                    if (flag[n] == 0)
                    {
                        flag[n] = 1;
                        resArray[i] = _nums[n];
                        break;
                    }

                }
            }

            return resArray;
        }
    }
}
