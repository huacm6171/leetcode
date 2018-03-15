﻿using System;

namespace CanWinNim
{
    public class Solution
    {
        public bool CanWinNim(int n)
        {
            return CanWinJudge(n, 0);
        }
        public bool CanWinJudge(int n, int deep)
        {
            Console.WriteLine("n:{0}, deep:{1}", n, deep);
            if (n <=3 && deep%2 == 0)
                return true;
            else if ( n <= 3)
                return false;

            if (CanWinJudge(n-1, deep + 1))
                return true;
            if (CanWinJudge(n-2, deep + 1))
                return true;
            if (CanWinJudge(n-3, deep + 1))
                return true;
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution mySL = new Solution();
            if(mySL.CanWinNim(1348820612))
                Console.WriteLine("True");
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
