using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace searchMatrix
{
    class Program
    {
        public static bool SearchMatrix(int[,] matrix, int target)
        {
            bool bRet = false;
            return bRet;
        }
        static void Main(string[] args)
        {
            int[,] matrix = new int[,] { {1,4,7,11,15 }, {2,5,8,12,19 }, {10,13,14,17,24 }, {18,21,23,26,30 } };
            int target = 5;
            SearchMatrix(matrix, target);
        }
    }
}
