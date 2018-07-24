using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions._3_Link
{
    public class MergeTwoLists
    {
        public ListNode Solution(ListNode l1, ListNode l2)
        {
            ListNode mergeRes = null;
            ListNode curNode = null;
            //assign head
            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    if (mergeRes == null)
                    {
                        mergeRes = l1;
                        curNode = mergeRes;
                    }
                    else
                    {
                        curNode.next = l1;
                        curNode = curNode.next; 
                    }
                        
                    l1 = l1.next;
                }
                else
                {
                    if (mergeRes == null)
                    {
                        mergeRes = l2;
                        curNode = mergeRes;
                    }
                    else
                    {
                        curNode.next = l2;
                        curNode = curNode.next;
                    }
                        
                    l2 = l2.next;
                }
            }
            while(l1 != null)
            {
                if (mergeRes == null)
                {
                    mergeRes = l1;
                    curNode = mergeRes;
                }
                else
                {
                    curNode.next = l1;
                    curNode = curNode.next;
                }
                l1 = l1.next;
            }
            while (l2 != null)
            {
                if (mergeRes == null)
                {
                    mergeRes = l2;
                    curNode = mergeRes;
                }
                else
                {
                    curNode.next = l2;
                    curNode = curNode.next;
                }
                l2 = l2.next;
            }
            return mergeRes;
        }
    }
}
