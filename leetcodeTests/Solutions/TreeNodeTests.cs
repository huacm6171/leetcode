using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcodeTests.Solutions.Tests
{
    [TestClass()]
    public class TreeNodeTests
    {
        [TestMethod()]
        public void TreenodeTest()
        {
            TreeNode root = new TreeNode(1);
            TreeNode node1 = new TreeNode(2);
            //TreeNode node2 = new TreeNode(2);
            root.left = null;
            root.right = node1;
            //node1.left = node2;

            _501FindModes myFm = new _501FindModes();
            myFm.FindMode(root);
            //Assert.Fail();
        }
    }
}