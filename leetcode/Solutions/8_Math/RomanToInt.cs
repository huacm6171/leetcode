using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions._8_Math
{
    public class RomanToInt
    {
        public int ConvertInt(string s)
        {
            int sum = 0;
            int tmp = 0;
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case 'I':
                        if (i + 1 < s.Length && (s[i + 1] == 'V' || s[i + 1] == 'X'))
                            tmp = -1;
                 
                        else
                            tmp = 1;
                        break;
                    case 'V':
                        tmp = 5;
                        break;
                    case 'X':
                        if (i + 1 < s.Length && (s[i + 1] == 'L' || s[i + 1] == 'C'))
                            tmp = -10;

                        else
                            tmp = 10;
                        break;
                    case 'L':
                        tmp = 50;
                        break;
                    case 'C':
                        if (i + 1 < s.Length && (s[i + 1] == 'D' || s[i + 1] == 'M'))
                            tmp = -100;

                        else
                            tmp = 100;
                        break;
                    case 'D':
                        tmp = 500;
                        break;
                    case 'M':
                        tmp = 1000;
                        break;

                    default:
                        break;
                }
                sum += tmp;
            }
            return sum;
        }
    }
}
