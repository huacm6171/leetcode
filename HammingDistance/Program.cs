using System;
using System.Collections.Generic;
using System.Text;

namespace HammingDistance
{
    public class Solution
    {
        public int HammingDistance(int x, int y){
            int iDis=0;
            while (x != 0 || y != 0)
            {
                int tmpX = x%2;
                int tmpY = y%2;
                if (tmpX != tmpY)
                    iDis += 1;
                x=x/2;
                y=y/2; 
                
                //Console.WriteLine("x:{0}, y:{1}", x, y);
            }
            return iDis;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution mySL = new Solution();
            int n = mySL.HammingDistance(1,4);
            Console.WriteLine("{0}", n);
        }
    }
}
