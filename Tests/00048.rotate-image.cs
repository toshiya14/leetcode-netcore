using LeetCode;

namespace Tests;

public class TestsRotateImage
{
    public SolutionRotateImage Solution { get; private set; }

    [SetUp]
    public void Setup()
    {
        this.Solution = new();
    }

    [Test]
    public void Test1()
    {
        {
            int[][] matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
            int[][] expected = [[7, 4, 1], [8, 5, 2], [9, 6, 3]];
            this.Solution.Rotate(matrix);
            for (var i = 0; i < matrix.Length; i++)
            {
                CollectionAssert.AreEqual(expected[i], matrix[i]);
            }
        }
        {
            int[][] matrix = [[5, 1, 9, 11], [2, 4, 8, 10], [13, 3, 6, 7], [15, 14, 12, 16]];
            int[][] expected = [[15, 13, 2, 5], [14, 3, 4, 1], [12, 6, 8, 9], [16, 7, 10, 11]];
            this.Solution.Rotate(matrix);
            for (var i = 0; i < matrix.Length; i++)
            {
                CollectionAssert.AreEqual(expected[i], matrix[i]);
            }
        }
        {
            int[][] matrix = [[1, 2], [3, 4]];
            int[][] expected = [[3, 1], [4, 2]];
            this.Solution.Rotate(matrix);
            for (var i = 0; i < matrix.Length; i++)
            {
                CollectionAssert.AreEqual(expected[i], matrix[i]);
            }
        }
        {
            int[][] matrix = [[1]];
            int[][] expected = [[1]];
            this.Solution.Rotate(matrix);
            for (var i = 0; i < matrix.Length; i++)
            {
                CollectionAssert.AreEqual(expected[i], matrix[i]);
            }
        }
        {
            int[][] matrix = [[]];
            int[][] expected = [[]];
            this.Solution.Rotate(matrix);
            for (var i = 0; i < matrix.Length; i++)
            {
                CollectionAssert.AreEqual(expected[i], matrix[i]);
            }
        }
    }
}
