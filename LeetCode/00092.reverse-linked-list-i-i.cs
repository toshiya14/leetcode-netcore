using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class SolutionReverseLinkedListII
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
    public ListNode ReverseBetween(ListNode head, int left, int right)
    {
        var ph = new ListNode() { next = head };
        var plp = ph;
        var pl = head;
        var index = 1;

        // find pl
        while (index < left)
        {
            plp = pl;
            pl = pl.next;
            index++;
        }
        var leftIsFirst = left == 1;

        var pr = pl;
        while (index < right)
        {
            pr = pr.next;
            index++;
        }

        var prn = pr.next;

        pr.next = null;
        var pnew = Reverse(pl, prn);

        if (leftIsFirst)
        {
            return pnew;
        }
        else
        {
            plp.next = pnew;
            return head;
        }
    }
    private static ListNode Reverse(ListNode head, ListNode? tail)
    {
        ListNode? pre = null;
        ListNode? cur = head;

        while (cur != null)
        {
            var next = cur.next;
            cur.next = pre;
            pre = cur;
            cur = next;
        }

        head.next = tail;

        return pre;
    }
}
