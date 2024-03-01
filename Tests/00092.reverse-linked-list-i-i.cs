using LeetCode;
using ListNode = LeetCode.SolutionReverseLinkedListII.ListNode;

namespace Tests;

public class TestsReverseLinkedListII
{
    public SolutionReverseLinkedListII Solution { get; private set; }

    [SetUp]
    public void Setup()
    {
        this.Solution = new();
    }

    [Test]
    public void Test1()
    {
        Assert.Multiple(() =>
        {
            var list = ListNode.FromList([1, 2, 3, 4, 5]);
            var result = this.Solution.ReverseBetween(list, 2, 4);
            CollectionAssert.AreEqual(new[] { 1, 4, 3, 2, 5 }, result.ToList().ToArray());

            list = ListNode.FromList([3, 5]);
            result = this.Solution.ReverseBetween(list, 1, 2);
            CollectionAssert.AreEqual(new[] { 5, 3 }, result.ToList().ToArray());
        });
    }
}
