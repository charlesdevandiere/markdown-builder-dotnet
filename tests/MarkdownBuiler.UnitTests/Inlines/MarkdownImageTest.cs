using Markdown;
using Xunit;

namespace MarkdownBuiler.UnitTests;

public class MarkdownImageTest
{
    [Fact]
    public void TestText()
    {
        Assert.Equal("image", new MarkdownImage("image", "url").Text);
    }

    [Fact]
    public void TestUrl()
    {
        Assert.Equal("url", new MarkdownImage("image", "url").Url);
    }

    [Fact]
    public void TestToString()
    {
        Assert.Equal("![image](url)", new MarkdownImage("image", "url").ToString());
    }

    [Fact]
    public void TestSetNullUrl()
    {
        var image = new MarkdownImage("image", "url");
#pragma warning disable CS8600, CS8625
        Assert.Throws<ArgumentNullException>(() => image.Url = null);
#pragma warning restore CS8600, CS8625
    }
}
