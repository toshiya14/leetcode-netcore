using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;

public class SolutionRemoveNthNodeFromEndOfList
{
    public class ListNode
    {
        public int val;
        public ListNode? next;

        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }

        public static ListNode? FromList(IList<int> list)
        {
            ListNode? head = null, p = null;
            foreach (var val in list)
            {
                if (head == null)
                {
                    head = new ListNode(val);
                    p = head;
                }
                else
                {
                    p!.next = new ListNode(val);
                    p = p.next;
                }
            }
            return head;
        }

        public IList<int> ToList()
        {
            var list = new List<int>();
            var p = this;
            while (p != null)
            {
                list.Add(p.val);
                p = p.next;
            }

            return list;
        }
    }

    public ListNode? RemoveNthFromEnd(ListNode head, int n)
    {
        if (head == null)
        {
            return head;
        }

        if (n == 1 && head.next == null)
        {
            return null;
        }

        var p1 = head;
        var p2 = head;


        for (var i = 0; i < n; i++)
        {
            p1 = p1.next;
        }

        if (p1 == null)
        {
            return head.next;
        }

        while (p1.next != null)
        {
            p1 = p1.next;
            p2 = p2.next;
        }

        if (n == 1)
        {
            p2.next = null;
        }
        else
        {
            p2.next = p2.next.next;
        }

        return head;
    }
}
