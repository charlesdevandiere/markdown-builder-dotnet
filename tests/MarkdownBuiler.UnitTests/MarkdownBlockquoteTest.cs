using System;
using Markdown;
using Xunit;

namespace MarkdownBuiler.UnitTests
{
    public class MarkdownBlockquoteTest
    {
        [Fact]
        public void TestText()
        {
            Assert.Equal("Blockquote", new MarkdownBlockquote("Blockquote").Text);
        }

        [Fact]
        public void TestInlineElement()
        {
            var inlineElement = new MarkdownText("Inline element");
            Assert.Equal("Inline element", new MarkdownBlockquote(inlineElement).Text);
        }

        [Fact]
        public void TestToString()
        {
            Assert.Equal($"> Blockquote{Environment.NewLine}", new MarkdownBlockquote("Blockquote").ToString());
        }
    }
}
