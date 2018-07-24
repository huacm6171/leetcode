using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions._3_Link
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public class DeleteNode
    {
        public void Solution1(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}
