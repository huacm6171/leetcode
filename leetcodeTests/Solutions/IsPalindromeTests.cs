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
    public class IsPalindromeTests
    {
        [TestMethod()]
        public void Solution1Test()
        {
            IsPalindrome ip = new IsPalindrome();
            string s = "A man, a plan, a canal: Panama";
            ip.Solution1(s);
            Assert.Fail();
        }
    }
}