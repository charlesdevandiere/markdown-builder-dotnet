using Markdown;
using Xunit;

namespace MarkdownBuiler.UnitTests;

public class MarkdownInlineCodeTest
{
    [Fact]
    public void TestText()
    {
        Assert.Equal("code", new MarkdownInlineCode("code").Text);
    }

    [Fact]
    public void TestInlineElement()
    {
        var inlineElement = new MarkdownText("Inline element");
        Assert.Equal("Inline element", new MarkdownInlineCode(inlineElement).Text);
    }

    [Fact]
    public void TestToString()
    {
        Assert.Equal("`code`", new MarkdownInlineCode("code").ToString());
    }

    [Fact]
    public void TestNullInlineElement()
    {
#pragma warning disable CS8600, CS8625
        Assert.Throws<ArgumentNullException>(() => new MarkdownInlineCode((MarkdownInlineElement)null));
#pragma warning restore CS8600, CS8625
    }
}
