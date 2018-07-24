using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions._3_Link
{
    public class HasCycle
    {
        public bool Solution(ListNode head)
        {
            bool bRet = false;
            ListNode curNode = head;
            while(curNode != null)
            {
                curNode = curNode.next;
                if (curNode == head)
                {
                    bRet = true;
                }
            }
            return bRet;
        }
    }
}
