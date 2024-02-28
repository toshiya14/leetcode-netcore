using LeetCode;

namespace Tests;

public class TestsSumOfUniqueElements
{
    public SolutionSumOfUniqueElements Solution { get; private set; }

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
            Assert.That(this.Solution.SumOfUnique([1, 2, 3, 2]), Is.EqualTo(4));
            Assert.That(this.Solution.SumOfUnique([1, 1, 1, 1, 1]), Is.EqualTo(0));
            Assert.That(this.Solution.SumOfUnique([1, 2, 3, 4, 5]), Is.EqualTo(15));
        });
    }
}
