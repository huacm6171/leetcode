using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions._2_String
{
    public class LongestCommonPre
    {
        public string Solution1(string[] strs)
        {
            List<char> preCommon = new List<char>();
            if (strs.Length == 1)
            {
                return strs[0];
            }
            else if (strs.Length == 0)
            {
                return "";
            }


            int i = 0;
            while (i< strs[0].Length && i<strs[1].Length)
            {
                if (strs[0][i] == strs[1][i])
                {
                    preCommon.Add(strs[0][i]);
                    i++;
                }
                else
                    break;
            }

            if (preCommon.Count == 0)
            {
                return "";
            }
            for (int j = 2; j < strs.Length; j++)
            {
                int n = 0;
                if (strs[j].Length == 0)
                {
                    return "";
                }
                while (n < preCommon.Count && n < strs[j].Length)
                {
                    if (preCommon[n] == strs[j][n])
                    {
                        n++;
                    }
                    else
                    {
                        break;
                    }
                }
                preCommon.RemoveRange(n, preCommon.Count - n);
            }
            return new string(preCommon.ToArray());
        }
    }
}
