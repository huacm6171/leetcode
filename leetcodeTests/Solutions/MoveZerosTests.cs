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
    public class MoveZerosTests
    {
        [TestMethod()]
        public void MoveZerosSolveTest()
        {
            MoveZeros myMZ = new MoveZeros();
            int[] nums = new int[] {1, 2, 3, 12};
            myMZ.MoveZerosSolve(nums);
            Assert.Fail();
        }
    }
}