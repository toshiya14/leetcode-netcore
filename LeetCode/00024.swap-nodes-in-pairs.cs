using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class SolutionSwapNodesInPairs
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

    public ListNode SwapPairs(ListNode head)
    {
        var p0 = head;
        ListNode newHead = null, lastTail = null;
        while (p0 != null)
        {
            var p1 = p0.next;
            if (p1 == null)
            {
                // Leave the last one alone.
                break;
            }

            var p2 = p1.next;

            p1.next = p0;
            p0.next = p2;

            if (lastTail != null)
            {
                lastTail.next = p1;
            }

            if (newHead == null)
            {
                newHead = p1;
            }

            lastTail = p0;
            p0 = p2;
        }

        return newHead ?? head;
    }
}
