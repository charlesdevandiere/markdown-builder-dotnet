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
            var blockquote = new MarkdownBlockquote("Blockquote");

            Assert.Equal("Blockquote", blockquote.Text);
        }

        [Fact]
        public void TestInlineElement()
        {
            var blockquote = new MarkdownBlockquote(new MarkdownText("Inline element"));

            Assert.Equal("Inline element", blockquote.Text);
        }

        [Fact]
        public void TestToString()
        {
            var blockquote = new MarkdownBlockquote("Blockquote");

            Assert.Equal($"> Blockquote{Environment.NewLine}{Environment.NewLine}", blockquote.ToString());
        }
    }
}
