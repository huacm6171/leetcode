using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions._4_Tree
{
    public class BST
    {
        public bool IsValidBST(TreeNode root)
        {
            bool bRet = true;
            if (root == null)
            {
                return true;
            }
            if (root.left != null && root.left.val >= root.val)
            {
                return false;
            }
            if (root.right != null && root.right.val <= root.val)
            {
                return false;
            }
            bool bLeftValid = IsValidBST(root.left);
            bool bRightValid = IsValidBST(root.right);
            if (!bLeftValid || !bRightValid)
            {
                return false;
            }
            return bRet;
        }
    }
}
