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
    public class CountAndSayTests
    {
        [TestMethod()]
        public void Solution1Test()
        {
            CountAndSay myCas = new CountAndSay();

            Assert.AreEqual("111221", myCas.Solution1(5));
        }
    }
}