using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode.Solutions._5_SortAndSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions._5_SortAndSearch.Tests
{
    [TestClass()]
    public class MergeArrayTests
    {
        [TestMethod()]
        public void MergeTest()
        {
            int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = new int[] { 2, 5, 6 };
            int n = 3;
            MergeArray ma = new MergeArray();
            ma.Merge(nums1, m, nums2, n);
            Assert.Fail();
        }
    }
}