using System;
using Markdown;
using Xunit;

namespace MarkdownBuiler.UnitTests
{
    public class MarkdownCodeTest
    {
        [Fact]
        public void TestText()
        {
            var code = new MarkdownCode("csharp", "var foo = \"Foo\";");

            Assert.Equal("var foo = \"Foo\";", code.Text);
        }

        [Fact]
        public void TestInlineElement()
        {
            var blockquote = new MarkdownCode("csharp", new MarkdownText("var foo = \"Foo\";"));

            Assert.Equal("var foo = \"Foo\";", blockquote.Text);
        }

        [Fact]
        public void TestLanguage()
        {
            var code = new MarkdownCode("csharp", "var foo = \"Foo\";");

            Assert.Equal("csharp", code.Language);
        }

        [Fact]
        public void TestToString()
        {
            var code = new MarkdownCode("csharp", "var foo = \"Foo\";");

            Assert.Equal("```csharp" + Environment.NewLine + "var foo = \"Foo\";" + Environment.NewLine + "```" + Environment.NewLine, code.ToString());
        }
    }
}
