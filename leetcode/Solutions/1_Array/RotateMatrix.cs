using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public class RotateMatrix
    {
        public void Solution1(int[,] matrix)
        {
            int n = matrix.GetLength(1);
            int tmp;
            //旋转公式：a[i,j]->a[j,n-i-1]->a[n-i-1,n-j-1]->a[n-j-1,i]->a[i,j],每个循环可对每层的四个元素位置进行移动。
            for (int i = 0; i < (n+1)/2; i++)
            {
                for (int j = 0; j < n-2*i -1; j++)
                {
                    tmp = matrix[i, i + j];
                    matrix[i, i + j] = matrix[n - i - j - 1, i];
                    matrix[n - i - j - 1, i] = matrix[n - i - 1, n - i - j - 1];
                    matrix[n - i - 1, n - i - j - 1] = matrix[i + j, n - i - 1];
                    matrix[i + j, n - i - 1] = tmp;
                }
            }
        }
    }
}
