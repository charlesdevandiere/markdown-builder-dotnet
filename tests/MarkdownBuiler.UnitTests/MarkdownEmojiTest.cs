using Markdown;
using Xunit;

namespace MarkdownBuiler.UnitTests
{
    public class MarkdownEmojiTest
    {
        [Fact]
        public void TestText()
        {
            Assert.Equal("thumbsup", new MarkdownEmoji("thumbsup").Text);
        }

        [Fact]
        public void TestToString()
        {
            Assert.Equal(":thumbsup:", new MarkdownEmoji("thumbsup").ToString());
        }
    }
}
