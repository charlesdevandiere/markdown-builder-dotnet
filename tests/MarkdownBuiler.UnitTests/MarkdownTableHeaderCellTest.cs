using Markdown;
using Xunit;

namespace MarkdownBuiler.UnitTests
{
    public class MarkdownTableHeaderCellTest
    {
        [Fact]
        public void TestText()
        {
            Assert.Equal("Text", new MarkdownTableHeaderCell("Text").Text);
        }

        [Fact]
        public void TestInlineELement()
        {
            var inlineElement = new MarkdownText("Inline element");
            Assert.Equal("Inline element", new MarkdownTableHeaderCell(inlineElement).Text);
        }

        [Fact]
        public void TestTextAlignment()
        {
            var inlineElement = new MarkdownText("Inline element");
            Assert.Equal(MarkdownTableTextAlignment.Center, new MarkdownTableHeaderCell("Text", MarkdownTableTextAlignment.Center).ColumnTextAlignment);
            Assert.Equal(MarkdownTableTextAlignment.Center, new MarkdownTableHeaderCell(inlineElement, MarkdownTableTextAlignment.Center).ColumnTextAlignment);
        }

        [Fact]
        public void TestDefaultTextAlignment()
        {
            var inlineElement = new MarkdownText("Inline element");
            Assert.Equal(MarkdownTableTextAlignment.Default, new MarkdownTableHeaderCell("Text").ColumnTextAlignment);
            Assert.Equal(MarkdownTableTextAlignment.Default, new MarkdownTableHeaderCell(inlineElement).ColumnTextAlignment);
        }

        [Fact]
        public void TestSetTextAlignment()
        {
            var headerCell = new MarkdownTableHeaderCell("Text");
            headerCell.ColumnTextAlignment = MarkdownTableTextAlignment.Center;
            Assert.Equal(MarkdownTableTextAlignment.Center, headerCell.ColumnTextAlignment);
        }
    }
}
