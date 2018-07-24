using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions._3_Link
{
    public class IsPalindrome
    {
        //网上思路：
        //1.首先获取链表长度
        //2.逆置链表前半部分，获取两个指针，分别指向前半部分和后半部分
        //3.挨个获取两个指针指向的元素进行比较，若相同则继续下一元素，若不同直接放回false
        public bool Solution( ListNode head)
        {
            bool bRet = true;
            //count the num of links
            int cnt = 0;
            ListNode curNode = head;
            while (curNode != null)
            {
                cnt++;
                curNode = curNode.next;
            }

            if (cnt == 2 && head.val != head.next.val)
            {
                bRet = false;
            }
            //递归判断
            curNode = head;
            //移动curNode到中间位置
            for (int i = 0; i < (cnt+1)/2; i++)
            {
                //若cnt为奇数，删除中间值
                //若cnt为偶数，判断当前及下一个节点是否相等
                curNode = curNode.next;

            }
            if (cnt%2 != 0 && cnt > 2)
            {
                curNode.val = curNode.next.val;
                curNode.next = curNode.next.next;
                bRet = Solution(head);
            }
            else if (cnt > 2)
            {
                if (curNode.val != curNode.next.val)
                {
                    bRet = false;
                }
                else
                {
                    curNode.val = curNode.next.next.val;
                    curNode.next = curNode.next.next.next;
                    bRet = Solution(head);
                }
            }

            return bRet;
        }
    }
}
