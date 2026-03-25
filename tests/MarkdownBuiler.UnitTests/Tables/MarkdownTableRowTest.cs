using Markdown;
using Xunit;

namespace MarkdownBuiler.UnitTests;

public class MarkdownTableRowTest
{
    [Fact]
    public void TestIEnumerableInlineElement()
    {
        Assert.Single(new MarkdownTableRow(new List<MarkdownInlineElement> { new MarkdownText("Inline Element") }).Cells);
    }

    [Fact]
    public void TestParamsInlineElement()
    {
        Assert.Single(new MarkdownTableRow(new MarkdownText("Inline Element")).Cells);
    }

    [Fact]
    public void TestIEnumerableString()
    {
        Assert.Single(new MarkdownTableRow(new List<string> { "Text" }).Cells);
    }

    [Fact]
    public void TestParamsString()
    {
        Assert.Single(new MarkdownTableRow("Text").Cells);
    }

    [Fact]
    public void TestToString()
    {
        Assert.Equal("| A | B | C |", new MarkdownTableRow("A", "B", "C").ToString());
    }

    [Fact]
    public void TestNullIEnumerableInlineElement()
    {
#pragma warning disable CS8600, CS8625
        Assert.Throws<ArgumentNullException>(() => new MarkdownTableRow((IEnumerable<MarkdownInlineElement>)null));
#pragma warning restore CS8600, CS8625
    }

    [Fact]
    public void TestNullIEnumerableString()
    {
#pragma warning disable CS8600, CS8625
        Assert.Throws<ArgumentNullException>(() => new MarkdownTableRow((IEnumerable<string>)null));
#pragma warning restore CS8600, CS8625
    }

    [Fact]
    public void TestNonPositiveCapacity()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new MarkdownTableRow(0));
        Assert.Throws<ArgumentOutOfRangeException>(() => new MarkdownTableRow(-1));
    }
}
