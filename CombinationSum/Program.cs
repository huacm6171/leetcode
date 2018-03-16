using System;
using System.Collections.Generic;

namespace CombinationSum
{
    public class Solution
    {
        private IList<IList<int>> ILRes;

        public IList<IList<int>> CombinationSum(int k, int n)
        {
            IList<int> il = new List<int>();
            getCombSum(1, il, k, n);
            return ILRes;
        }
        public void getCombSum(int iCurDeep, IList<int> iLTmp, int k, int n)
        {
            int start = 0;
            int sum = 0;
            if (iLTmp.Count != 0)
            {
                start = iLTmp[iLTmp.Count -1];
            }
            foreach (var item in iLTmp)
                    {
                        sum += item;
                    }
            for (int i = start + 1; i < 10; i++)
            {
                
                if( sum + i > n)
                        return ; 
                
                iLTmp.Add(i);

                if( iCurDeep == k)
                {
                    if(sum + i == n)
                    {
                        ILRes.Add(iLTmp);
                        return;
                    }
                }
                else
                {
                    getCombSum(iCurDeep + 1, iLTmp, k, n);
                }
            }
            return ;
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            IList<IList<int>> ILRes;
            Solution mySL = new Solution();
            ILRes = mySL.CombinationSum(3, 7);
            foreach (var item in ILRes)
            {
                foreach (var item1 in item)
                {
                    Console.WriteLine("{0}", item1); 
                }
            }
        }
    }
}
