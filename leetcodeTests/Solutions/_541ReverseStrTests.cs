using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Tests
{
    [TestClass()]
    public class _541ReverseStrTests
    {
        [TestMethod()]
        public void ReverseStrTest()
        {
            string str = "abcdefg";
            string strRet = "";
            int k = 2;
            _541ReverseStr myReverseStr = new _541ReverseStr();

            strRet =  myReverseStr.ReverseStr(str, k);
            Console.WriteLine("result:{0}", strRet);
        }
    }
}