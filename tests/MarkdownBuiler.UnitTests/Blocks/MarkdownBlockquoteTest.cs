using Markdown;
using Xunit;

namespace MarkdownBuiler.UnitTests;

public class MarkdownBlockquoteTest
{
    [Fact]
    public void TestText()
    {
        Assert.Equal("Blockquote", new MarkdownBlockquote("Blockquote").Text);
    }

    [Fact]
    public void TestInlineElement()
    {
        var inlineElement = new MarkdownText("Inline element");
        Assert.Equal("Inline element", new MarkdownBlockquote(inlineElement).Text);
    }

    [Fact]
    public void TestToString()
    {
        Assert.Equal($"> Blockquote{Environment.NewLine}", new MarkdownBlockquote("Blockquote").ToString());
    }

    [Fact]
    public void TestNullInlineElement()
    {
#pragma warning disable CS8600, CS8625
        Assert.Throws<ArgumentNullException>(() => new MarkdownBlockquote((MarkdownInlineElement)null));
#pragma warning restore CS8600, CS8625
    }
}
