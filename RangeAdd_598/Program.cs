using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeAdd_598
{
    class Program
    {
        public static int MaxCount(int m, int n, int[,] ops)
        {
            int minX ,minY;
            minX = m;
            minY = n;
            int ix = ops.GetLength(0);
            for (int i = 0; i < ix; i++)
            {
                minX = minX > ops[i, 0] ? ops[i, 0] : minX;
                minY = minY > ops[i, 1] ? ops[i, 1] : minY;
            }
            return (minX+1)*(minY+1);
        }
        static void Main(string[] args)
        {
            int[,] ops = new int[,] { { 2,2},{3,3 }, { 1,1} };
            MaxCount(3,3,ops);
        }
    }
}
