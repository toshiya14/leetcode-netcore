using LeetCode;

namespace Tests;

public class TestsRemoveElement
{
    public SolutionRemoveElement Solution { get; private set; }

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
            int[] array = [3, 2, 2, 3];
            var length = this.Solution.RemoveElement(array, 3);
            Assert.That(length, Is.EqualTo(2));
            CollectionAssert.AreEquivalent(new[] { 2, 2 }, array.Take(length));

            array = [0, 1, 2, 2, 3, 0, 4, 2];
            length = this.Solution.RemoveElement(array, 2);
            Assert.That(length, Is.EqualTo(5));
            CollectionAssert.AreEquivalent(new[] { 0, 1, 3, 0, 4 }, array.Take(length));

            array = [1];
            length = this.Solution.RemoveElement(array, 1);
            Assert.That(length, Is.EqualTo(0));
        });
    }
}
