﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode.Solutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions.Tests
{
    [TestClass()]
    public class RotateArrayTests
    {
        [TestMethod()]
        public void SolutionsOneTest()
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;
            RotateArray myRa = new RotateArray();
            myRa.SolutionsOne(nums, k);
            Assert.Fail();
        }
    }
}