using Markdown;
using Xunit;

namespace MarkdownBuiler.UnitTests
{
    public class MarkdownCheckListItemTest
    {
        [Fact]
        public void TestChecked()
        {
            Assert.True(new MarkdownCheckListItem(true, "Text").Checked);
        }

        [Fact]
        public void TestUnchecked()
        {
            Assert.False(new MarkdownCheckListItem(false, "Text").Checked);
        }

        [Fact]
        public void TestText()
        {
            Assert.Equal("Text", new MarkdownCheckListItem(true, "Text").Text);
        }

        [Fact]
        public void TestInlineElement()
        {
            Assert.Equal("Inline element", new MarkdownCheckListItem(true, new MarkdownText("Inline element")).Text);
        }

        [Fact]
        public void TestToString()
        {
            Assert.Equal("[x] Text", new MarkdownCheckListItem(true, "Text").ToString());
            Assert.Equal("[ ] Text", new MarkdownCheckListItem(false, "Text").ToString());
        }
    }
}
