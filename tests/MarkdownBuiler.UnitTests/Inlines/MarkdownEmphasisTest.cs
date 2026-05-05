using Markdown;
using Xunit;

namespace MarkdownBuiler.UnitTests;

public class MarkdownEmphasisTest
{
    [Fact]
    public void TestText()
    {
        Assert.Equal("Emphasis", new MarkdownEmphasis("Emphasis").Text);
    }

    [Fact]
    public void TestTextWithChar()
    {
        Assert.Equal('*', new MarkdownEmphasis("Emphasis", '*').Char);
        Assert.Equal('_', new MarkdownEmphasis("Emphasis", '_').Char);
    }

    [Fact]
    public void TestTextWithInvalidChar()
    {
        Assert.Throws<ArgumentException>(() => new MarkdownEmphasis("Emphasis", 'a'));
    }

    [Fact]
    public void TestInlineElement()
    {
        var inlineElement = new MarkdownText("Inline element");
        Assert.Equal("Inline element", new MarkdownEmphasis(inlineElement).Text);
    }

    [Fact]
    public void TestInlineElementWithChar()
    {
        var inlineElement = new MarkdownText("Inline element");
        Assert.Equal('*', new MarkdownEmphasis(inlineElement, '*').Char);
        Assert.Equal('_', new MarkdownEmphasis(inlineElement, '_').Char);
    }

    [Fact]
    public void TestInlineElementWithInvalidChar()
    {
        var inlineElement = new MarkdownText("Inline element");
        Assert.Throws<ArgumentException>(() => new MarkdownEmphasis(inlineElement, 'a'));
    }

    [Fact]
    public void TestToString()
    {
        Assert.Equal("*Emphasis*", new MarkdownEmphasis("Emphasis").ToString());
    }

    [Fact]
    public void TestSetInvalidChar()
    {
        var emphasis = new MarkdownEmphasis("text");
        Assert.Throws<ArgumentException>(() => emphasis.Char = 'a');
    }

    [Fact]
    public void TestNullInlineElement()
    {
#pragma warning disable CS8600, CS8625
        Assert.Throws<ArgumentNullException>(() => new MarkdownEmphasis((MarkdownInlineElement)null));
#pragma warning restore CS8600, CS8625
    }
}
