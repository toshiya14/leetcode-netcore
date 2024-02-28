using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class SolutionAddTwoNumbers
{
    public class ListNode(int val = 0, ListNode? next = null)
    {
        public int val = val;
        public ListNode? next = next;
    }

    public ListNode? AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode? head = null, p3 = null;

        var p1 = l1;
        var p2 = l2;
        var rest = 0;

        while (p1 != null || p2 != null)
        {
            if (p3 == null)
            {
                // init.
                p3 = new ListNode();
                head = p3;
            }
            else
            {
                p3.next = new ListNode();
                p3 = p3.next;
            }

            var v1 = p1 == null ? 0 : p1.val;
            var v2 = p2 == null ? 0 : p2.val;

            var v3 = v1 + v2 + rest;
            rest = v3 / 10;
            p3.val = v3 % 10;

            p1 = p1?.next;
            p2 = p2?.next;
        }

        if (rest != 0)
        {
            p3!.next = new ListNode(rest);
        }

        return head;
    }
}
