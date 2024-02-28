using System.Text;
using LeetCode;
using ListNode = LeetCode.SolutionAddTwoNumbers.ListNode;

namespace Tests;

public class TestsAddTwoNumbers
{
    public SolutionAddTwoNumbers Solution { get; private set; }

    [SetUp]
    public void Setup()
    {
        this.Solution = new SolutionAddTwoNumbers();
    }

    private static ListNode? MakeLinkNodes(int[] nums)
    {
        ListNode? last = null;
        ListNode? head = null;
        foreach (var num in nums)
        {
            var node = new ListNode(num, null);
            if (last is not null)
            {
                last.next = node;
            }
            head ??= node;
            last = node;
        }

        return head;
    }

    private static bool ListNodeEquals(ListNode? first, ListNode? second)
    {
        var p1 = first;
        var p2 = second;

        while (p1 != null && p2 != null)
        {
            var firstValue = p1.val;
            var secondValue = p2.val;
            if (firstValue != secondValue)
            {
                return false;
            }
            p1 = p1.next;
            p2 = p2.next;
        }

        return p1 == null && p2 == null;
    }

    private static string Format(ListNode? head)
    {
        var sb = new StringBuilder();
        var p = head;
        while (p != null)
        {
            sb.Append(p.val);
            p = p.next;
        }

        return new string(sb.ToString().Reverse().ToArray());
    }

    [Test]
    public void Test1()
    {
        Assert.Multiple(() =>
        {
            var tl = MakeLinkNodes([1, 2, 3]);
            var p = tl;
            Console.WriteLine($"LINKNODES: [123][0] -> {p!.val}");
            Assert.That(p!.val, Is.EqualTo(1));
            p = p.next;
            Console.WriteLine($"LINKNODES: [123][1] -> {p!.val}");
            Assert.That(p!.val, Is.EqualTo(2));
            p = p.next;
            Console.WriteLine($"LINKNODES: [123][2] -> {p!.val}");
            Assert.That(p!.val, Is.EqualTo(3));
            Assert.That(p!.next, Is.Null);

            var equals = ListNodeEquals(tl, MakeLinkNodes([1, 2, 3]));
            Console.WriteLine($"LISTNODE EQUALS TEST: {equals}");
            Assert.That(equals);

            var str = Format(tl);
            Console.WriteLine($"FORMAT: {str}");
            Assert.That(str, Is.EqualTo("321"));

            Assert.That(() =>
            {
                var l1 = MakeLinkNodes([2, 4, 3]);
                var l2 = MakeLinkNodes([5, 6, 4]);
                var r = this.Solution.AddTwoNumbers(l1!, l2!);
                Console.WriteLine($"TEST: {Format(l1)} + {Format(l2)} = {Format(r)}");
                return ListNodeEquals(r, MakeLinkNodes([7, 0, 8]));
            });
            Assert.That(() =>
            {
                var l1 = MakeLinkNodes([0]);
                var l2 = MakeLinkNodes([0]);
                var r = this.Solution.AddTwoNumbers(l1!, l2!);
                Console.WriteLine($"TEST: {Format(l1)} + {Format(l2)} = {Format(r)}");
                return ListNodeEquals(r, MakeLinkNodes([0]));
            });
            Assert.That(() =>
            {
                var l1 = MakeLinkNodes([9, 9, 9, 9, 9, 9, 9]);
                var l2 = MakeLinkNodes([9, 9, 9, 9]);
                var r = this.Solution.AddTwoNumbers(l1!, l2!);
                Console.WriteLine($"TEST: {Format(l1)} + {Format(l2)} = {Format(r)}");
                return ListNodeEquals(r, MakeLinkNodes([8, 9, 9, 9, 0, 0, 0, 1]));
            });
        });
    }
}