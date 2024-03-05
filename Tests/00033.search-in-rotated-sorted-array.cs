using LeetCode;

namespace Tests;

public class TestsSearchInRotatedSortedArray
{
    public SolutionSearchInRotatedSortedArray Solution { get; private set; }

    [SetUp]
    public void Setup()
    {
        this.Solution = new();
    }

    [Test]
    public void Test1()
    {
        {
            int[] array = [];
            var target = 1;
            Assert.That(this.Solution.Search(array, target), Is.EqualTo(-1));
        }
        {
            int[] array = [1];
            var target = 1;
            Assert.That(this.Solution.Search(array, target), Is.EqualTo(0));
        }
        {
            int[] array = [3, 4];
            var target = 1;
            Assert.That(this.Solution.Search(array, target), Is.EqualTo(-1));
        }
        {
            int[] array = [4, 3, 1];
            var target = 1;
            Assert.That(this.Solution.Search(array, target), Is.EqualTo(2));
        }
        {
            int[] array = [3, 4, 5, 1, 2];
            var target = 1;
            Assert.That(this.Solution.Search(array, target), Is.EqualTo(3));
        }
        {
            int[] array = [3, 4, 5, 1, 2];
            var target = 3;
            Assert.That(this.Solution.Search(array, target), Is.EqualTo(0));
        }
        {
            int[] array = [3, 4, 5, 1, 2];
            var target = 3;
            Assert.That(this.Solution.Search(array, target), Is.EqualTo(0));
        }
        {
            int[] array = [1, 2, 3, 4, 5];
            var target = 1;
            Assert.That(this.Solution.Search(array, target), Is.EqualTo(0));
        }
        {
            int[] array = [1, 2, 3, 4, 5];
            var target = 3;
            Assert.That(this.Solution.Search(array, target), Is.EqualTo(2));
        }
        {
            int[] array = [1, 2, 3, 4, 5];
            var target = 5;
            Assert.That(this.Solution.Search(array, target), Is.EqualTo(4));
        }
        {
            int[] array = [4, 5, 6, 7, 0, 1, 2];
            var target = 3;
            Assert.That(this.Solution.Search(array, target), Is.EqualTo(-1));
        }
    }
}
