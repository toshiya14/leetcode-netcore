using LeetCode;

namespace Tests;

public class TestsIntegerToRoman
{
    public SolutionIntegerToRoman Solution { get; private set; }

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
            Assert.That(this.Solution.IntToRoman(3), Is.EqualTo("III"));
            Assert.That(this.Solution.IntToRoman(4), Is.EqualTo("IV"));
            Assert.That(this.Solution.IntToRoman(9), Is.EqualTo("IX"));
            Assert.That(this.Solution.IntToRoman(58), Is.EqualTo("LVIII"));
            Assert.That(this.Solution.IntToRoman(1994), Is.EqualTo("MCMXCIV"));
        });
    }
}
