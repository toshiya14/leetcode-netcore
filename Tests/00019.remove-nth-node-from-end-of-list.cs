using LeetCode;
using ListNode = LeetCode.SolutionRemoveNthNodeFromEndOfList.ListNode;
namespace Tests;

public class TestsRemoveNthNodeFromEndOfList
{
    public SolutionRemoveNthNodeFromEndOfList Solution { get; private set; }

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
            var head = ListNode.FromList([1, 2, 3, 4, 5]);
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 5 }, this.Solution.RemoveNthFromEnd(head!, 2)!.ToList().ToArray());

            head = ListNode.FromList([1, 2]);
            CollectionAssert.AreEqual(new[] { 1 }, this.Solution.RemoveNthFromEnd(head!, 1)!.ToList().ToArray());
        });
    }
}
