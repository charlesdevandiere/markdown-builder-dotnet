using Markdown;
using Xunit;

namespace MarkdownBuiler.UnitTests;

public class MarkdownStrikethroughTest
{
    [Fact]
    public void TestText()
    {
        Assert.Equal("Strikethrough", new MarkdownStrikethrough("Strikethrough").Text);
    }

    [Fact]
    public void TestInlineElement()
    {
        var inlineElement = new MarkdownText("Inline element");
        Assert.Equal("Inline element", new MarkdownStrikethrough(inlineElement).Text);
    }

    [Fact]
    public void TestToString()
    {
        Assert.Equal("~~Strikethrough~~", new MarkdownStrikethrough("Strikethrough").ToString());
    }

    [Fact]
    public void TestNullInlineElement()
    {
#pragma warning disable CS8600, CS8625
        Assert.Throws<ArgumentNullException>(() => new MarkdownStrikethrough((MarkdownInlineElement)null));
#pragma warning restore CS8600, CS8625
    }
}
