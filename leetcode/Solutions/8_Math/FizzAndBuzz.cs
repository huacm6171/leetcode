using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions._8_Math
{
    public class FizzAndBuzz
    {
        public IList<string> FizzBuzz(int n)
        {
            List<string> lRes = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                lRes.Add("");
                if (i % 3 == 0)
                {
                    lRes[i - 1] += "Fizz";
                }
                if (i % 5 == 0)
                {
                    lRes[i - 1] += "Buzz";
                }
                if (i % 3 != 0 && i % 5 != 0)
                    lRes[i - 1] += i.ToString();
            }
            return lRes;
        }
    }
}
