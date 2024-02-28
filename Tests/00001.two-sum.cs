using LeetCode;

namespace Tests;

public class TestsTwoSum
{
    public SolutionTwoSum Solution { get; private set; }

    [SetUp]
    public void Setup()
    {
        this.Solution = new SolutionTwoSum();
    }

    [Test]
    public void Test1()
    {
        Assert.Multiple(() =>
        {
            Assert.That(() => this.Solution.TwoSum([2, 7, 11, 15], 9).SequenceEqual([0, 1]));
            Assert.That(() => this.Solution.TwoSum([3, 2, 4], 6).SequenceEqual([1, 2]));
            Assert.That(() => this.Solution.TwoSum([3, 3], 6).SequenceEqual([0, 1]));
        });
    }
}