using Markdown;
using Xunit;

namespace MarkdownBuiler.UnitTests;

public class MarkdownCodeTest
{
    [Fact]
    public void TestText()
    {
        Assert.Equal("var foo = \"Foo\";", new MarkdownCode("csharp", "var foo = \"Foo\";").Text);
    }

    [Fact]
    public void TestInlineElement()
    {
        var inlineElement = new MarkdownText("var foo = \"Foo\";");
        Assert.Equal("var foo = \"Foo\";", new MarkdownCode("csharp", inlineElement).Text);
    }

    [Fact]
    public void TestLanguage()
    {
        Assert.Equal("csharp", new MarkdownCode("csharp", "var foo = \"Foo\";").Language);
    }

    [Fact]
    public void TestToString()
    {
        Assert.Equal(
            "```csharp" + Environment.NewLine + "var foo = \"Foo\";" + Environment.NewLine + "```" + Environment.NewLine,
            new MarkdownCode("csharp", "var foo = \"Foo\";").ToString()
        );
    }

    [Fact]
    public void TestSetNullLanguage()
    {
        var code = new MarkdownCode("csharp", "code");
#pragma warning disable CS8600, CS8625
        Assert.Throws<ArgumentNullException>(() => code.Language = null);
#pragma warning restore CS8600, CS8625
    }

    [Fact]
    public void TestNullInlineElement()
    {
#pragma warning disable CS8600, CS8625
        Assert.Throws<ArgumentNullException>(() => new MarkdownCode("csharp", (MarkdownInlineElement)null));
#pragma warning restore CS8600, CS8625
    }
}
