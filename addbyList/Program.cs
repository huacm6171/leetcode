using System;

namespace addbyList
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x){ val = x;}
    }
    class Program
    {
        static public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode lRes = new ListNode(0);
            ListNode curLN = lRes;
            int flag =0;
            int curSum = 0;
            while (l1 != null|| l2 != null|| flag != 0)
            {
                
                curSum = (l1!=null?l1.val:0) + (l2!=null? l2.val:0) + flag;
                l1 = (l1 !=null)? l1.next:l1;
                l2 = (l2 !=null)? l2.next:l2;
                
                flag = curSum/10;
                ListNode ln = new ListNode(curSum%10);
                curLN.next = ln;
                curLN = ln;
                
            } 
            return lRes.next;
        }
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(5);
            //ListNode ln1 = new ListNode(4);
            //ListNode ln11 = new ListNode(3);
            ListNode l2 = new ListNode(5);
            //ListNode ln2 = new ListNode(6);
            //ListNode ln22 = new ListNode(4);
            //l1.next = ln1;
            //ln1.next = ln11;
            //l2.next = ln2;
            //ln2.next = ln22;
            AddTwoNumbers(l1, l2);


            Console.WriteLine("Hello World!");
        }
    }
}
