using LeetCode;

namespace Tests;

public class TestsMedianOfTwoSortedArrays
{
    public SolutionMedianOfTwoSortedArrays Solution { get; private set; }

    [SetUp]
    public void Setup()
    {
        this.Solution = new SolutionMedianOfTwoSortedArrays();
    }

    [Test]
    public void Test1()
    {
        Assert.Multiple(() =>
        {
            Assert.That(this.Solution.FindMedianSortedArrays([1, 3], [2]), Is.EqualTo(2.0));
            Assert.That(this.Solution.FindMedianSortedArrays([1, 2], [3, 4]), Is.EqualTo(2.5));
            Assert.That(this.Solution.FindMedianSortedArrays([], [2, 3]), Is.EqualTo(2.5));
        });
    }
}