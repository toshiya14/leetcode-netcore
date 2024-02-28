using System.Linq;
using LeetCode;

namespace Tests;

public class TestsZigZagConversion
{
    public SolutionZigZagConversion Solution { get; private set; }

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
            Assert.That(this.Solution.Convert("PAYPALISHIRING", 3), Is.EqualTo("PAHNAPLSIIGYIR"));
            Assert.That(this.Solution.Convert("PAYPALISHIRING", 4), Is.EqualTo("PINALSIGYAHRPI"));
        });
    }
}