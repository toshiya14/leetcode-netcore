using LeetCode;

namespace Tests;

public class TestsLongestPalindromicSubstring
{
    public SolutionLongestPalindromicSubstring Solution { get; private set; }

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
            Assert.That(this.Solution.LongestPalindrome("abcdcbabb"), Is.EqualTo("abcdcba"));
            Assert.That(this.Solution.LongestPalindrome("babad"), Is.EqualTo("bab"));
            Assert.That(this.Solution.LongestPalindrome("cbbd"), Is.EqualTo("bb"));
        });
    }
}