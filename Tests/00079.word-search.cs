using LeetCode;

namespace Tests;

public class TestsWordSearch
{
    public SolutionWordSearch Solution { get; private set; }

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
            //Assert.That(this.Solution.Exist([['A', 'B', 'C', 'E'], ['S', 'F', 'C', 'S'], ['A', 'D', 'E', 'E']], "ABCCED"), Is.EqualTo(true));
            //Assert.That(this.Solution.Exist([['A', 'B', 'C', 'E'], ['S', 'F', 'C', 'S'], ['A', 'D', 'E', 'E']], "ABCB"), Is.EqualTo(false));
            Assert.That(this.Solution.Exist([['A', 'B', 'C', 'E'], ['S', 'F', 'E', 'S'], ['A', 'D', 'E', 'E']], "ABCESEEEFS"), Is.EqualTo(true));
        });
    }
}
