using Markdown;
using Xunit;

namespace MarkdownBuiler.UnitTests
{
    public class MarkdownLinkTest
    {
        [Fact]
        public void TestText()
        {
            Assert.Equal("text", new MarkdownLink("text", "url").Text);
        }

        [Fact]
        public void TestUrl()
        {
            Assert.Equal("url", new MarkdownLink("text", "url").Url);
        }

        [Fact]
        public void TestInlineElement()
        {
            var inlineElement = new MarkdownText("Inline element");
            Assert.Equal("Inline element", new MarkdownLink(inlineElement, "url").Text);
        }

        [Fact]
        public void TestToString()
        {
            Assert.Equal("[text](url)", new MarkdownLink("text", "url").ToString());
        }
    }
}
