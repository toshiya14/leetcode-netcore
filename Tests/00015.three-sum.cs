using LeetCode;

namespace Tests;

public class TestsThreeSum
{
    public SolutionThreeSum Solution { get; private set; }

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
            var cols = this.Solution.ThreeSum([-1, 0, 1, 2, -1, -4]);
            Assert.That(cols, Has.Count.EqualTo(2));
            CollectionAssert.AreEquivalent(new[] { -1, -1, 2 }, cols[0]);
            CollectionAssert.AreEquivalent(new[] { -1, 0, 1 }, cols[1]);

            cols = this.Solution.ThreeSum([0, 0, 0, 0]);
            Assert.That(cols, Has.Count.EqualTo(1));
            CollectionAssert.AreEquivalent(new[] { 0, 0, 0 }, cols[0]);

        });
    }
}
