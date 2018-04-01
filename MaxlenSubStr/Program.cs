using System;
using System.Collections.Generic;

namespace MaxlenSubStr
{
    class Program
    {
        public static int LengthOfLongestSubStr(string s)
        {
            int maxLen = 0;
            int tmpLen = 0;
            int start = 0;
            for (int i = 0; i < s.Length; i++)
            {
                string subStr = s.Substring(start, i-start);
                int iIndex = subStr.IndexOf(s[i]);
                if (iIndex != -1 )
                {
                   start = start + iIndex + 1;
                }
                tmpLen = i - start +1;
                maxLen = maxLen > tmpLen?maxLen:tmpLen;
            }   
            return maxLen;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int maxLen;
            maxLen = LengthOfLongestSubStr("abcdeaaabb");
        }
    }
}
