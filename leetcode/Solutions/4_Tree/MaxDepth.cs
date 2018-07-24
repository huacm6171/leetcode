using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions._4_Tree
{
    public class MaxDepth
    {
        public int getMaxDepth(TreeNode root)
        {
            int iDepth = 1;
            if (root == null)
            {
                return 0;
            }
            int iLeftDepth = 0;
            int iRightDepth = 0;
            if (root.left != null)
            {
                iLeftDepth = getMaxDepth(root.left);
            }
            if (root.right != null)
            {
                iRightDepth = getMaxDepth(root.right);
            }
            iDepth += iLeftDepth > iRightDepth ? iLeftDepth : iRightDepth;
//            if (root.right != null|| root.right != null)
//            {
//                iDepth++;
//            }
            return iDepth;
        }
    }
}
