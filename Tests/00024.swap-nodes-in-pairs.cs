using LeetCode;
using ListNode = LeetCode.SolutionSwapNodesInPairs.ListNode;
namespace Tests;

public class TestsSwapNodesInPairs
{
    public SolutionSwapNodesInPairs Solution { get; private set; }

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
            var head = ListNode.FromList([1, 2, 3, 4]);
            CollectionAssert.AreEquivalent(new[] { 2, 1, 4, 3 }, this.Solution.SwapPairs(head).ToList());
            head = ListNode.FromList([2, 5, 3, 4, 6, 2, 2]);
            CollectionAssert.AreEquivalent(new[] { 5, 2, 4, 3, 2, 6, 2 }, this.Solution.SwapPairs(head).ToList());
        });
    }
}
