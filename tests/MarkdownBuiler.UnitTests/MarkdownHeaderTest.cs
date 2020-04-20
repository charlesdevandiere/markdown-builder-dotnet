using System;
using Markdown;
using Xunit;

namespace MarkdownBuiler.UnitTests
{
    public class MarkdownHeaderTest
    {
        [Fact]
        public void TestText()
        {
            Assert.Equal("Text", new MarkdownHeader("Text", 1).Text);
        }

        [Fact]
        public void TestInlineElement()
        {
            Assert.Equal("Inline element", new MarkdownHeader(new MarkdownText("Inline element"), 1).Text);
        }

        [Fact]
        public void TestLevel()
        {
            Assert.Equal(1, new MarkdownHeader("Text", 1).Level);
            Assert.Equal(1, new MarkdownHeader(new MarkdownText("Inline element"), 1).Level);
        }

        [Fact]
        public void TestInvalidLevel()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new MarkdownHeader("Text", 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new MarkdownHeader(new MarkdownText("Inline element"), 0));
            
            Assert.Throws<ArgumentOutOfRangeException>(() => new MarkdownHeader("Text", 7));
            Assert.Throws<ArgumentOutOfRangeException>(() => new MarkdownHeader(new MarkdownText("Inline element"), 7));
        }

        [Fact]
        public void TestToString()
        {
            Assert.Equal("# Header" + Environment.NewLine, new MarkdownHeader("Header", 1).ToString());
            Assert.Equal("## Header" + Environment.NewLine, new MarkdownHeader("Header", 2).ToString());
            Assert.Equal("### Header" + Environment.NewLine, new MarkdownHeader("Header", 3).ToString());
            Assert.Equal("#### Header" + Environment.NewLine, new MarkdownHeader("Header", 4).ToString());
            Assert.Equal("##### Header" + Environment.NewLine, new MarkdownHeader("Header", 5).ToString());
            Assert.Equal("###### Header" + Environment.NewLine, new MarkdownHeader("Header", 6).ToString());
        }
    }
}
