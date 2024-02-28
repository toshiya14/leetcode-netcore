using LeetCode;

namespace Tests;

public class Tests__name__
{
    public Solution__name__ Solution { get; private set; }

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
            Assert.That(this.Solution.Resolve(1), Is.EqualTo(1));
        });
    }
}