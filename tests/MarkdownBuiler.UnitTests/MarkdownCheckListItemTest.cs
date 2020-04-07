using Markdown;
using Xunit;

namespace MarkdownBuiler.UnitTests
{
    public class MarkdownCheckListItemTest
    {
        [Fact]
        public void TestChecked()
        {
            var item = new MarkdownCheckListItem(true, "Text");

            Assert.True(item.Checked);
        }

        [Fact]
        public void TestUnchecked()
        {
            var item = new MarkdownCheckListItem(false, "Text");

            Assert.False(item.Checked);
        }

        [Fact]
        public void TestText()
        {
            var item = new MarkdownCheckListItem(true, "Text");

            Assert.Equal("Text", item.Text);
        }

        [Fact]
        public void TestToString()
        {
            Assert.Equal("[x] Text", new MarkdownCheckListItem(true, "Text").ToString());
            Assert.Equal("[ ] Text", new MarkdownCheckListItem(false, "Text").ToString());
        }
    }
}
