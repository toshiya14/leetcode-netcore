using LeetCode;

namespace Tests;

public class TestsDivideTwoIntegers
{
    public SolutionDivideTwoIntegers Solution { get; private set; }

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
            Assert.That(this.Solution.Divide(1, 1), Is.EqualTo(1));
            Assert.That(this.Solution.Divide(0, 1), Is.EqualTo(0));
            Assert.That(this.Solution.Divide(100, 5), Is.EqualTo(20));
            Assert.That(this.Solution.Divide(-100, 5), Is.EqualTo(-20));
            Assert.That(this.Solution.Divide(-100, -5), Is.EqualTo(20));
            Assert.That(this.Solution.Divide(100, -5), Is.EqualTo(-20));
            Assert.That(this.Solution.Divide(10, 3), Is.EqualTo(3));
            Assert.That(this.Solution.Divide(1, 3), Is.EqualTo(0));
            Assert.That(this.Solution.Divide(int.MinValue, -1), Is.EqualTo(int.MaxValue));
            Assert.That(this.Solution.Divide(-2147483648, 2), Is.EqualTo(-1073741824));
        });
    }
}
