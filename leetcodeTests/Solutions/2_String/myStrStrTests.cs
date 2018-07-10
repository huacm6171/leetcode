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
    public class myStrStrTests
    {
        [TestMethod()]
        public void StrStrTest()
        {
            myStrStr mySS = new myStrStr();

            Assert.AreEqual(-1, mySS.StrStr("aaa", "aaaaa"));
        }
    }
}