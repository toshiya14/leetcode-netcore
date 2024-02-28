using LeetCode;

namespace Tests;

public class TestsSolutionSingleNumber
{
    public SolutionSingleNumber Solution { get; private set; }

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
            Assert.That(this.Solution.SingleNumber([2, 2, 1]), Is.EqualTo(1));
            Assert.That(this.Solution.SingleNumber([4, 1, 2, 1, 2]), Is.EqualTo(4));
            Assert.That(this.Solution.SingleNumber([1]), Is.EqualTo(1));
        });
    }
}