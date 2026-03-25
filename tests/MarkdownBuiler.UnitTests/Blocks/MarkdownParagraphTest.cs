using Markdown;
using Xunit;

namespace MarkdownBuiler.UnitTests;

public class MarkdownParagraphTest
{
    [Fact]
    public void TestText()
    {
        Assert.Equal("Paragraph", new MarkdownParagraph("Paragraph").Text);
    }

    [Fact]
    public void TestInlineElement()
    {
        var inlineElement = new MarkdownText("Inline element");
        Assert.Equal("Inline element", new MarkdownParagraph(inlineElement).Text);
    }

    [Fact]
    public void TestToString()
    {
        Assert.Equal("Paragraph" + Environment.NewLine, new MarkdownParagraph("Paragraph").ToString());
    }

    [Fact]
    public void TestNullInlineElement()
    {
#pragma warning disable CS8600, CS8625
        Assert.Throws<ArgumentNullException>(() => new MarkdownParagraph((MarkdownInlineElement)null));
#pragma warning restore CS8600, CS8625
    }
}
