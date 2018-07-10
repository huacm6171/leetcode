using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions._2_String
{
    public class myStrStr
    {
        public int StrStr(string haystack, string needle)
        {
            int retVal = -1;
            if (needle == "")
            {
                return 0;
            }
            for (int i = 0; i < haystack.Length; i++)
            {              
                if (haystack.Length - i < needle.Length)
                    break;
                if (haystack.Substring(i,needle.Length) == needle)
                {
                    retVal = i;
                    break;
                }
                //int tmp = i;

                //for (int j = 0; j < needle.Length; j++)
                //{
                    
                //    if (haystack[tmp] == needle[j])
                //    {
                //        tmp++;
                //    }
                //    else
                //        break;
                //}
                //if (tmp - i == needle.Length)
                //{
                //    retVal = i;
                //    break;
                //}
            }
            return retVal;
        }
    }
}
