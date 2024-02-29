using LeetCode;

namespace Tests;

public class TestsThreeSumClosest
{
    public SolutionThreeSumClosest Solution { get; private set; }

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
            Assert.That(this.Solution.ThreeSumClosest([-1, 2, 1, -4], 1), Is.EqualTo(2));
            Assert.That(this.Solution.ThreeSumClosest([0, 0, 0], 1), Is.EqualTo(0));
            Assert.That(this.Solution.ThreeSumClosest([4, 0, 5, -5, 3, 3, 0, -4, -5], -2), Is.EqualTo(-2));
            Assert.That(this.Solution.ThreeSumClosest([1, 1, 1, 0], -100), Is.EqualTo(2));
            Assert.That(this.Solution.ThreeSumClosest([0, 3, 97, 102, 200], 300), Is.EqualTo(300));
        });
    }
}
