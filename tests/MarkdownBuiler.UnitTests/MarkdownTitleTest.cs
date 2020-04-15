using System;
using Markdown;
using Xunit;

namespace MarkdownBuiler.UnitTests
{
    public class MarkdownTitleTest
    {
        [Fact]
        public void TestText()
        {
            Assert.Equal("Text", new MarkdownTitle("Text", 1).Text);
        }

        [Fact]
        public void TestInlineElement()
        {
            Assert.Equal("Inline element", new MarkdownTitle(new MarkdownText("Inline element"), 1).Text);
        }

        [Fact]
        public void TestLevel()
        {
            Assert.Equal(1, new MarkdownTitle("Text", 1).Level);
            Assert.Equal(1, new MarkdownTitle(new MarkdownText("Inline element"), 1).Level);
        }

        [Fact]
        public void TestInvalidLevel()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new MarkdownTitle("Text", 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new MarkdownTitle(new MarkdownText("Inline element"), 0));
            
            Assert.Throws<ArgumentOutOfRangeException>(() => new MarkdownTitle("Text", 7));
            Assert.Throws<ArgumentOutOfRangeException>(() => new MarkdownTitle(new MarkdownText("Inline element"), 7));
        }

        [Fact]
        public void TestToString()
        {
            Assert.Equal("# Title" + Environment.NewLine, new MarkdownTitle("Title", 1).ToString());
            Assert.Equal("## Title" + Environment.NewLine, new MarkdownTitle("Title", 2).ToString());
            Assert.Equal("### Title" + Environment.NewLine, new MarkdownTitle("Title", 3).ToString());
            Assert.Equal("#### Title" + Environment.NewLine, new MarkdownTitle("Title", 4).ToString());
            Assert.Equal("##### Title" + Environment.NewLine, new MarkdownTitle("Title", 5).ToString());
            Assert.Equal("###### Title" + Environment.NewLine, new MarkdownTitle("Title", 6).ToString());
        }
    }
}
