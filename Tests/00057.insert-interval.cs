using LeetCode;

namespace Tests;

public class TestsInsertInterval
{
    public SolutionInsertInterval Solution { get; private set; }

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
            //{
            //    int[][] intervals = [[1, 3], [6, 9]];
            //    int[] newInterval = [2, 5];
            //    int[][] result = [[1, 5], [6, 9]];
            //    CollectionAssert.AreEquivalent(result, this.Solution.Insert(intervals, newInterval));
            //}
            //{
            //    int[][] intervals = [[1, 2], [3, 5], [6, 7], [8, 10], [12, 16]];
            //    int[] newInterval = [4, 8];
            //    int[][] result = [[1, 2], [3, 10], [12, 16]];
            //    CollectionAssert.AreEquivalent(result, this.Solution.Insert(intervals, newInterval));
            //}
            //{
            //    int[][] intervals = [];
            //    int[] newInterval = [4, 8];
            //    int[][] result = [[4, 8]];
            //    CollectionAssert.AreEquivalent(result, this.Solution.Insert(intervals, newInterval));
            //}
            //{
            //    int[][] intervals = [[1, 2]];
            //    int[] newInterval = [4, 8];
            //    int[][] result = [[1, 2], [4, 8]];
            //    CollectionAssert.AreEquivalent(result, this.Solution.Insert(intervals, newInterval));
            //}
            //{
            //    int[][] intervals = [[4, 8]];
            //    int[] newInterval = [1, 2];
            //    int[][] result = [[1, 2], [4, 8]];
            //    CollectionAssert.AreEquivalent(result, this.Solution.Insert(intervals, newInterval));
            //}
            //{
            //    int[][] intervals = [[1, 2], [3, 4], [5, 6]];
            //    int[] newInterval = [2, 5];
            //    int[][] result = [[1, 6]];
            //    CollectionAssert.AreEquivalent(result, this.Solution.Insert(intervals, newInterval));
            //}
            //{
            //    int[][] intervals = [[1, 2], [3, 4], [5, 6]];
            //    int[] newInterval = [2, 4];
            //    int[][] result = [[1, 4], [5, 6]];
            //    CollectionAssert.AreEquivalent(result, this.Solution.Insert(intervals, newInterval));
            //}
            //{
            //    int[][] intervals = [[1, 2], [3, 4], [5, 6]];
            //    int[] newInterval = [3, 5];
            //    int[][] result = [[1, 2], [3, 6]];
            //    CollectionAssert.AreEquivalent(result, this.Solution.Insert(intervals, newInterval));
            //}
            //{
            //    int[][] intervals = [[1, 5]];
            //    int[] newInterval = [2, 3];
            //    int[][] result = [[1, 5]];
            //    CollectionAssert.AreEquivalent(result, this.Solution.Insert(intervals, newInterval));
            //}
            {
                int[][] intervals = [[3, 5], [12, 15]];
                int[] newInterval = [6, 6];
                int[][] result = [[3, 5], [6, 6], [12, 15]];
                CollectionAssert.AreEquivalent(result, this.Solution.Insert(intervals, newInterval));
            }
        });
    }
}
