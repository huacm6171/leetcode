using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions._3_Link
{
    public class RemoveNthFromEnd
    {
        public ListNode Solution1(ListNode head, int n)
        {
            int cnt = 0;
            ListNode tmp = head;
            while (tmp != null)
            {
                cnt++;
                tmp = tmp.next;
            }

            if (cnt == 1 && cnt == 1)
            {
                head = null;
            }

            int i = 0;
            tmp = head;
            
            while(tmp !=null)
            {
                if (n == 1&& i== cnt-n-1)
                {
                    tmp.next = null;
                    break;
                }
                else if (i == cnt-n)
                {
                    tmp.val = tmp.next.val;
                    tmp.next = tmp.next.next;
                    break;
                }
                tmp = tmp.next;
                i++;
            }
            //delete last element
            
            return head;
        }
    }
}
