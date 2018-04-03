using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountBinSubStrs
{
    

    class Program
    {
        public static int CountBinSubStrings(string s)
        {
            char preAlpha;
            int cnt = 0;
            int preAlphaCnt = 0;
            int nexAlphaCnt = 0;
            preAlpha = s[0];
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == preAlpha && nexAlphaCnt == 0)
                    preAlphaCnt++;
                else if (s[i] != preAlpha)
                    nexAlphaCnt++;
                else
                {
                    cnt += preAlphaCnt < nexAlphaCnt ? preAlphaCnt : nexAlphaCnt;
                    preAlpha = preAlpha == '0' ? '1' : '0';
                    preAlphaCnt = nexAlphaCnt;
                    nexAlphaCnt = 1;
                }
            }
            cnt += preAlphaCnt < nexAlphaCnt ? preAlphaCnt : nexAlphaCnt;
            return cnt;
        }
        static void Main(string[] args)
        {
            string s = "10101";
            int n;
            n = CountBinSubStrings(s);
            Console.WriteLine("{0}", n);
        }
    }
}
