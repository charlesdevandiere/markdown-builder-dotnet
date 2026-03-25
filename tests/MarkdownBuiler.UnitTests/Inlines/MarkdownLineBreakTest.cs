using Markdown;
using Xunit;

namespace MarkdownBuiler.UnitTests;

public class MarkdownLineBreakTest
{
    [Fact]
    public void TestText()
    {
        Assert.Equal(string.Empty, new MarkdownLineBreak().Text);
    }

    [Fact]
    public void TestToString()
    {
        Assert.Equal($"<br>{Environment.NewLine}", new MarkdownLineBreak().ToString());
    }

    [Fact]
    public void TestCompositionWithMarkdownText()
    {
        var text = new MarkdownText("Line 1")
            .Append(new MarkdownLineBreak())
            .Append("Line 2");
        Assert.Equal($"Line 1<br>{Environment.NewLine}Line 2", text.ToString());
    }
}
