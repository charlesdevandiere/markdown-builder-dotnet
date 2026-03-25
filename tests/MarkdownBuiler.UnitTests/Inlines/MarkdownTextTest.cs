using Markdown;
using Xunit;

namespace MarkdownBuiler.UnitTests;

public class MarkdownTextTest
{
    [Fact]
    public void TestText()
    {
        Assert.Equal("Text", new MarkdownText("Text").Text);
    }

    [Fact]
    public void TestInlineElement()
    {
        Assert.Equal("Inline element", new MarkdownText(new MarkdownText("Inline element")).Text);
    }

    [Fact]
    public void TestAppendText()
    {
        Assert.Equal("Text Append", new MarkdownText("Text").Append(" Append").Text);
    }

    [Fact]
    public void TestAppendInlineElement()
    {
        Assert.Equal("Inline element Append", new MarkdownText(new MarkdownText("Inline element")).Append(new MarkdownText(" Append")).Text);
    }

    [Fact]
    public void TestToString()
    {
        var text = new MarkdownText("Markdown");
        text.Append(" Builder ");
        text.Append(new MarkdownEmoji("thumbsup"));
        Assert.Equal("Markdown Builder :thumbsup:", text.ToString());
    }

    [Fact]
    public void TestNullInlineElement()
    {
#pragma warning disable CS8600, CS8625
        Assert.Throws<ArgumentNullException>(() => new MarkdownText((MarkdownInlineElement)null));
#pragma warning restore CS8600, CS8625
    }
}
