using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode.Solutions._3_Link;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions._3_Link.Tests
{
    [TestClass()]
    public class RemoveNthFromEndTests
    {
        [TestMethod()]
        public void Solution1Test()
        {
            ListNode head = new ListNode(1);
            ListNode node1 = new ListNode(2);
            ListNode node2 = new ListNode(3);
            ListNode node3 = new ListNode(4);
            ListNode node4 = new ListNode(5);
            head.next = node1;
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;

            RemoveNthFromEnd myRNFE = new RemoveNthFromEnd();
            myRNFE.Solution1(head, 5);
            myRNFE.Solution1(head, 1);
            myRNFE.Solution1(node4, 1);

            Assert.Fail();
        }
    }
}