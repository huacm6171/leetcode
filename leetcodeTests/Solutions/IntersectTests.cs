using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode.Solutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions.Tests
{
    [TestClass()]
    public class IntersectTests
    {
        [TestMethod()]
        public void IntersectSolveTest()
        {
            int[] nums1 = new int[]{1,2,2,1};
            int[] nums2 = new int[] { 2, 2 };
            Intersect myIntersect = new Intersect();
            myIntersect.IntersectSolve(nums1, nums2);
            Assert.Fail();
        }
    }
}