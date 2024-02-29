using LeetCode;

namespace Tests;

public class TestsSimplifyPath
{
    public SolutionSimplifyPath Solution { get; private set; }

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
            Assert.That(this.Solution.SimplifyPath("/"), Is.EqualTo("/"));
            Assert.That(this.Solution.SimplifyPath("//home"), Is.EqualTo("/home"));
            Assert.That(this.Solution.SimplifyPath("/../home"), Is.EqualTo("/home"));
            Assert.That(this.Solution.SimplifyPath("/home/"), Is.EqualTo("/home"));
            Assert.That(this.Solution.SimplifyPath("/home/.."), Is.EqualTo("/"));
            Assert.That(this.Solution.SimplifyPath("/home/.."), Is.EqualTo("/"));
            Assert.That(this.Solution.SimplifyPath("/home/././"), Is.EqualTo("/home"));
            Assert.That(this.Solution.SimplifyPath("/home/./sub/"), Is.EqualTo("/home/sub"));
            Assert.That(this.Solution.SimplifyPath("/home/./sub/.."), Is.EqualTo("/home"));
        });
    }
}
