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
    public class ContainsDuplicateTests
    {
        [TestMethod()]
        public void ContainsDuplicateSolutionTest()
        {
            int[] testArray = new int[] { 1, 3, 4, 6, 7, 2, 1, 5 };
            ContainsDuplicate myCD = new ContainsDuplicate();
            myCD.ContainsDuplicateSolution(testArray);
            Assert.Fail();
        }
    }
}