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
    public class _27_RemoveElementTests
    {
        [TestMethod()]
        public void RemoveElementTest()
        {
            int[] nums = new int[] { 1 };
            int val = 1;
            _27_RemoveElement re = new _27_RemoveElement();
            re.RemoveElement(nums, val);
            Assert.Fail();
        }
    }
}