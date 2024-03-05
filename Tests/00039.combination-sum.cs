using LeetCode;

namespace Tests;

public class TestsCombinationSum
{
    public SolutionCombinationSum Solution { get; private set; }

    [SetUp]
    public void Setup()
    {
        this.Solution = new();
    }

    [Test]
    public void Test1()
    {
        {
            int[] input = [2, 3, 6, 7];
            var target = 7;
            int[][] expected = [[2, 2, 3], [7]];
            var results = this.Solution.CombinationSum(input, target);
            Assert.That(results.Count, Is.EqualTo(expected.Length));
            for (var i = 0; i < expected.Length; i++)
            {
                CollectionAssert.AreEquivalent(expected[i], results[i]);
            }
        }
        {
            int[] input = [2, 3, 5];
            var target = 8;
            int[][] expected = [[2, 2, 2, 2], [2, 3, 3], [3, 5]];
            var results = this.Solution.CombinationSum(input, target);
            Assert.That(results.Count, Is.EqualTo(expected.Length));
            for (var i = 0; i < expected.Length; i++)
            {
                CollectionAssert.AreEquivalent(expected[i], results[i]);
            }
        }
        {
            int[] input = [8, 7, 4, 3];
            var target = 11;
            int[][] expected = [[8, 3], [7, 4], [4, 4, 3]];
            var results = this.Solution.CombinationSum(input, target);
            Assert.That(results.Count, Is.EqualTo(expected.Length));
            for (var i = 0; i < expected.Length; i++)
            {
                CollectionAssert.AreEquivalent(expected[i], results[i]);
            }
        }
    }
}
