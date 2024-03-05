using LeetCode;

namespace Tests;

public class TestsMultiplyStrings
{
    public SolutionMultiplyStrings Solution { get; private set; }

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
            Assert.That(this.Solution.Multiply("2", "3"), Is.EqualTo("6"));
            Assert.That(this.Solution.Multiply("11", "3"), Is.EqualTo("33"));
            Assert.That(this.Solution.Multiply("99", "99"), Is.EqualTo("9801"));
            Assert.That(this.Solution.Multiply("11", "10"), Is.EqualTo("110"));
            Assert.That(this.Solution.Multiply("22", "333"), Is.EqualTo("7326"));
            Assert.That(this.Solution.Multiply("0", "10"), Is.EqualTo("0"));
        });
    }
}
