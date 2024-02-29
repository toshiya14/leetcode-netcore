using LeetCode;

namespace Tests;

public class TestsLetterCombinationsOfAPhoneNumber
{
    public SolutionLetterCombinationsOfAPhoneNumber Solution { get; private set; }

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
            CollectionAssert.AreEquivalent(new[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" }, this.Solution.LetterCombinations("23"));
        });
    }
}
