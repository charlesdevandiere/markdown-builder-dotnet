using Markdown;
using Xunit;

namespace MarkdownBuiler.UnitTests;

public class MarkdownStringEmphasisTest
{
    [Fact]
    public void TestText()
    {
        Assert.Equal("Strong emphasis", new MarkdownStrongEmphasis("Strong emphasis").Text);
    }

    [Fact]
    public void TestInlineElement()
    {
        var inlineElement = new MarkdownText("Inline element");
        Assert.Equal("Inline element", new MarkdownStrongEmphasis(inlineElement).Text);
    }

    [Fact]
    public void TestToString()
    {
        Assert.Equal("**Strong emphasis**", new MarkdownStrongEmphasis("Strong emphasis").ToString());
    }

    [Fact]
    public void TestNullInlineElement()
    {
#pragma warning disable CS8600, CS8625
        Assert.Throws<ArgumentNullException>(() => new MarkdownStrongEmphasis((MarkdownInlineElement)null));
#pragma warning restore CS8600, CS8625
    }
}
