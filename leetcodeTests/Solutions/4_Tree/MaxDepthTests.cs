using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode.Solutions._4_Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions._4_Tree.Tests
{
    [TestClass()]
    public class MaxDepthTests
    {
        [TestMethod()]
        public void getMaxDepthTest()
        {
            TreeNode root = new TreeNode(3);
            TreeNode left1 = new TreeNode(9);
            TreeNode right1 = new TreeNode(20);
            TreeNode left2 = new TreeNode(15);
            TreeNode right2 = new TreeNode(7);
            root.left = left1;
            root.right = right1;
            right1.left = left2;
            right1.right = right2;
            MaxDepth md = new MaxDepth();

            Assert.AreEqual(3, md.getMaxDepth(root));
            Assert.Fail();
        }
    }
}