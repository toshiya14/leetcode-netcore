using LeetCode;

namespace Tests;

public class TestsGenerateParenteses
{
    public SolutionGenerateParenteses Solution { get; private set; }

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
            CollectionAssert.AreEquivalent(new[] { "((()))", "(()())", "(())()", "()(())", "()()()" }, this.Solution.GenerateParenthesis(3));
        });
    }
}
