using Markdown;
using Xunit;

namespace MarkdownBuiler.UnitTests;

public class MarkdownBlockquoteTest
{
    [Fact]
    public void TestSimpleText()
    {
        var blockquote = new MarkdownBlockquote("Blockquote");
        Assert.Equal($"> Blockquote{Environment.NewLine}", blockquote.ToString());
    }

    [Fact]
    public void TestInlineElement()
    {
        var inlineElement = new MarkdownText("Inline element");
        var blockquote = new MarkdownBlockquote(inlineElement);
        Assert.Equal($"> Inline element{Environment.NewLine}", blockquote.ToString());
    }

    [Fact]
    public void TestSingleBlockElement()
    {
        var blockquote = new MarkdownBlockquote(new MarkdownParagraph("Hello world"));
        Assert.Equal($"> Hello world{Environment.NewLine}", blockquote.ToString());
    }

    [Fact]
    public void TestMultipleBlockElements()
    {
        var blockquote = new MarkdownBlockquote(
            new MarkdownParagraph("First paragraph"),
            new MarkdownParagraph("Second paragraph")
        );

        var expected = string.Join(Environment.NewLine,
            "> First paragraph",
            ">",
            "> Second paragraph",
            "");

        Assert.Equal(expected, blockquote.ToString());
    }

    [Fact]
    public void TestNestedBlockquote()
    {
        var blockquote = new MarkdownBlockquote(
            new MarkdownParagraph("Outer quote"),
            new MarkdownBlockquote("Inner quote")
        );

        var expected = string.Join(Environment.NewLine,
            "> Outer quote",
            ">",
            "> > Inner quote",
            "");

        Assert.Equal(expected, blockquote.ToString());
    }

    [Fact]
    public void TestMixedContent()
    {
        var blockquote = new MarkdownBlockquote(
            new MarkdownParagraph("A paragraph"),
            new MarkdownList("Item 1", "Item 2")
        );

        var expected = string.Join(Environment.NewLine,
            "> A paragraph",
            ">",
            "> - Item 1",
            "> - Item 2",
            "");

        Assert.Equal(expected, blockquote.ToString());
    }

    [Fact]
    public void TestBlockElementsListManipulation()
    {
        var blockquote = new MarkdownBlockquote(new MarkdownParagraph("First"));
        blockquote.BlockElements.Add(new MarkdownParagraph("Second"));

        Assert.Equal(2, blockquote.BlockElements.Count);

        var expected = string.Join(Environment.NewLine,
            "> First",
            ">",
            "> Second",
            "");

        Assert.Equal(expected, blockquote.ToString());
    }

    [Fact]
    public void TestEnumerableConstructor()
    {
        var elements = new List<IMarkdownBlockElement>
        {
            new MarkdownParagraph("One"),
            new MarkdownParagraph("Two")
        };

        var blockquote = new MarkdownBlockquote(elements);
        Assert.Equal(2, blockquote.BlockElements.Count);
    }
}
