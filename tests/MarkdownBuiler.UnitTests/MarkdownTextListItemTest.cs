using Markdown;
using Xunit;

namespace MarkdownBuiler.UnitTests
{
    public class MarkdownTextListItemTest
    {
        [Fact]
        public void TestText()
        {
            Assert.Equal("Text", new MarkdownTextListItem("Text").Text);
        }

        [Fact]
        public void TestInlineElement()
        {
            Assert.Equal("Inline element", new MarkdownTextListItem(new MarkdownText("Inline element")).Text);
        }

        [Fact]
        public void TestToString()
        {
            Assert.Equal("Text", new MarkdownTextListItem("Text").ToString());
        }
    }
}
