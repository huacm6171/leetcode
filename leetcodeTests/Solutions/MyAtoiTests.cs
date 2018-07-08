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
    public class MyAtoiTests
    {
        [TestMethod()]
        public void Solution1Test()
        {
            MyAtoi ai = new MyAtoi();
            string s1 = " -0012a42";
            string s2 = "4193 with words";
            string s3 = "words and 987";
            string s4 = "-91283472332";
            string s5 = "    -43";
            
            Assert.AreEqual(-12, ai.Solution1(s1));
        }
    }
}