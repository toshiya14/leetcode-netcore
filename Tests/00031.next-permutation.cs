using LeetCode;

namespace Tests;

public class TestsNextPermutation
{
    public SolutionNextPermutation Solution { get; private set; }

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
            int[] testcase = [1, 2, 3, 4, 5];
            this.Solution.NextPermutation(testcase);
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 5, 4 }, testcase);

            testcase = [5, 4, 3, 2, 1];
            this.Solution.NextPermutation(testcase);
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5 }, testcase);

            testcase = [4, 5, 3, 2, 1];
            this.Solution.NextPermutation(testcase);
            CollectionAssert.AreEqual(new[] { 5, 1, 2, 3, 4 }, testcase);

            testcase = [1, 2, 3, 5, 4];
            this.Solution.NextPermutation(testcase);
            CollectionAssert.AreEqual(new[] { 1, 2, 4, 3, 5 }, testcase);

            testcase = [1];
            this.Solution.NextPermutation(testcase);
            CollectionAssert.AreEqual(new[] { 1 }, testcase);

            testcase = [1, 2];
            this.Solution.NextPermutation(testcase);
            CollectionAssert.AreEqual(new[] { 2, 1 }, testcase);

            testcase = [2, 1, 3];
            this.Solution.NextPermutation(testcase);
            CollectionAssert.AreEqual(new[] { 2, 3, 1 }, testcase);

            testcase = [2, 3, 1, 3, 3];
            this.Solution.NextPermutation(testcase);
            CollectionAssert.AreEqual(new[] { 2, 3, 3, 3, 1 }, testcase);

            testcase = [];
            this.Solution.NextPermutation(testcase);
            Assert.That(testcase.Count, Is.EqualTo(0));

        });
    }
}
