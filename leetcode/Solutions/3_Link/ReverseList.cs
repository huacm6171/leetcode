using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions._3_Link
{
    public class ReverseList
    {
        public ListNode Solution1(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            ListNode reverseHead = Solution1(head.next);
            //最后一个元素标记为head元素
            if (reverseHead == null)
            {
                head.next = null;
                return head;
            }
            ListNode curNode = reverseHead;
            while (curNode.next != null)
            {
                curNode = curNode.next;
            }
            curNode.next = head;
            head.next = null;
            return reverseHead;
        }

        public ListNode Solution2(ListNode head)
        {
            ListNode tmpNode = null;
            ListNode curNode = null;

            while (head.next != null)
            {
                curNode = head;
                head = head.next;

                curNode.next = tmpNode;
                tmpNode = curNode;
                 
            }
            if (head != null)
            {
                head.next = curNode;
            }
            
            return head;
        }
    }
}
