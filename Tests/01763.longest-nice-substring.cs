using LeetCode;

namespace Tests;

public class TestsLongestNiceSubstring
{
    public SolutionLongestNiceSubstring Solution { get; private set; }

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
            Assert.That(this.Solution.LongestNiceSubstring("YazaAay"), Is.EqualTo("aAa"));
            Assert.That(this.Solution.LongestNiceSubstring("Bb"), Is.EqualTo("Bb"));
            Assert.That(this.Solution.LongestNiceSubstring("c"), Is.EqualTo(string.Empty));
            Assert.That(this.Solution.LongestNiceSubstring("dDzeE"), Is.EqualTo("dD"));
        });
    }
}
