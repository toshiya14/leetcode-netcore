using LeetCode;

namespace Tests;

public class TestsPlusOne
{
    public SolutionPlusOne Solution { get; private set; }

    [SetUp]
    public void Setup()
    {
        this.Solution = new();
    }

    [Test]
    public void Test1()
    {
        {
            int[] input = [0];
            int[] expected = [1];
            CollectionAssert.AreEqual(expected, this.Solution.PlusOne(input));
        }
        {
            int[] input = [9];
            int[] expected = [1, 0];
            CollectionAssert.AreEqual(expected, this.Solution.PlusOne(input));
        }
        {
            int[] input = [9, 9, 9];
            int[] expected = [1, 0, 0, 0];
            CollectionAssert.AreEqual(expected, this.Solution.PlusOne(input));
        }
        {
            int[] input = [8, 9, 9];
            int[] expected = [9, 0, 0];
            CollectionAssert.AreEqual(expected, this.Solution.PlusOne(input));
        }
        {
            int[] input = [4, 5, 6];
            int[] expected = [4, 5, 7];
            CollectionAssert.AreEqual(expected, this.Solution.PlusOne(input));
        }
    }
}
