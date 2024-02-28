using LeetCode;

namespace Tests;

public class TestsMinimumLimitOfBallsInABag
{
    public SolutionMinimumLimitOfBallsInABag Solution { get; private set; }

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
            Assert.That(this.Solution.MinimumSize([1], 1), Is.EqualTo(1));
            Assert.That(this.Solution.MinimumSize([9], 2), Is.EqualTo(3));
            Assert.That(this.Solution.MinimumSize([2, 4, 8, 2], 4), Is.EqualTo(2));
        });
    }
}
