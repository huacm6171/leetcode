using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode.Solutions._2_String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions._2_String.Tests
{
    [TestClass()]
    public class LongestCommonPreTests
    {
        [TestMethod()]
        public void Solution1Test()
        {
            string[] strs1 = new string[] { "ac", "ac", "a", "a"};
            string[] strs2 = new string[] { "hello" };
            string[] strs3 = new string[] { "dog", "racecar", "car" };
            LongestCommonPre lcp = new LongestCommonPre();

            Assert.AreEqual("a",lcp.Solution1(strs1));
            //Assert.AreEqual("hello", lcp.Solution1(strs1));
            //Assert.AreEqual("", lcp.Solution1(strs1));
        }
    }
}