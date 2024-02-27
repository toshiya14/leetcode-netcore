using LeetCode;

namespace Tests;

public class TestsLongestSubstringWithoutRepeatingCharacters
{
    public OfficialSolutionLongestSubstringWithoutRepeatingCharacters Solution { get; private set; }

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
            Assert.That(this.Solution.LengthOfLongestSubstring("abcabcbb"), Is.EqualTo(3));
            Assert.That(this.Solution.LengthOfLongestSubstring("bbbbb"), Is.EqualTo(1));
            Assert.That(this.Solution.LengthOfLongestSubstring("pwwkew"), Is.EqualTo(3));
            Assert.That(this.Solution.LengthOfLongestSubstring("au"), Is.EqualTo(2));
        });
    }
}